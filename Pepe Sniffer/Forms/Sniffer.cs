using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;

namespace PepeSniffer
{
    public partial class Sniffer : Form
    {
        public Sniffer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Array containing all the network interfaces in your PC.
        /// </summary>
        private NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

        /// <summary>
        /// Represents the monitor that listens on the selected interface.
        /// </summary>
        private Monitor currentMonitor;

        /// <summary>
        /// List of all monitors to listen on.
        /// </summary>
        private List<Monitor> monitorList = new List<Monitor>();

        /// <summary>
        /// Data source of the DGV.
        /// </summary>
        private DataTable dataTable = new DataTable();

        /// <summary>
        /// Sets the columns of the DGV and fills the ComboBox with the interfaces.
        /// </summary>
        private void LoadControls()
        {
            dataTable.Columns.Add("source_ip");
            dataTable.Columns.Add("source_port");
            dataTable.Columns.Add("destination_ip");
            dataTable.Columns.Add("destination_port");
            dataTable.Columns.Add("protocol");
            dataTable.Columns.Add("time");
            dataTable.Columns.Add("length", typeof(int));
            dataTable.Columns.Add("data");

            // Hidden columns
            dataTable.Columns.Add("hex");
            dataTable.Columns.Add("raw", typeof(byte[]));

            DGV.AutoGenerateColumns = false;
            DGV.DataSource = dataTable;
            DGV.Columns["SourceIp"].DataPropertyName = "source_ip";
            DGV.Columns["SourcePort"].DataPropertyName = "source_port";
            DGV.Columns["DestinationIp"].DataPropertyName = "destination_ip";
            DGV.Columns["DestinationPort"].DataPropertyName = "destination_port";
            DGV.Columns["Protocol"].DataPropertyName = "protocol";
            DGV.Columns["Time"].DataPropertyName = "time";
            DGV.Columns["Length"].DataPropertyName = "length";
            DGV.Columns["Data"].DataPropertyName = "data";

            // Hidden columns
            DGV.Columns["Hex"].DataPropertyName = "hex";
            DGV.Columns["Raw"].DataPropertyName = "raw";

            for (var i = 0; i <= networkInterfaces.Length - 1; i++)
                cbInterfaces.Items.Add(networkInterfaces[i].Name);

            cbInterfaces.SelectedIndex = 0;
        }

        /// <summary>
        /// Starts listening on the selected interface and therefore to receive packets.
        /// </summary>
        /// <returns>Returns true if it was able to start listening on the selected interface, otherwise false.</returns>
        private bool StartReceiving()
        {
            if (cbInterfaces.SelectedIndex == 0) // All interfaces
            {
                monitorList.Clear();
                IPAddress[] hosts = Dns.GetHostEntry(Dns.GetHostName()).AddressList;

                for (int i = 0; i < hosts.Length; i++)
                {
                    Monitor monitor = new Monitor(hosts[i]);
                    monitor.PacketEventHandler += new Monitor.NewPacketEventHandler(OnNewPacket);
                    monitorList.Add(monitor);
                }

                foreach (Monitor monitor in monitorList)
                {
                    monitor.Start();
                }
                return true;
            }
            else
            {
                int index = cbInterfaces.SelectedIndex - 1;

                IPAddress myIp = null;
                IPInterfaceProperties interfaceProperties = networkInterfaces[index].GetIPProperties();

                for (int i = 0; i <= interfaceProperties.UnicastAddresses.Count - 1; i++)
                {
                    if (interfaceProperties.UnicastAddresses[i].Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        myIp = interfaceProperties.UnicastAddresses[i].Address;
                    }
                }

                try
                {
                    currentMonitor = new Monitor(myIp);
                    currentMonitor.PacketEventHandler += new Monitor.NewPacketEventHandler(OnNewPacket);
                    currentMonitor.Start();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot listen on " + networkInterfaces[index].Name, "Connection error", default, MessageBoxIcon.Error);
                    return false;
                }
            }
            
        }

        /// <summary>
        /// Stops capturing packets.
        /// </summary>
        private void StopReceiving()
        {
            if (cbInterfaces.SelectedIndex == 0) // All interfaces
            {
                foreach (Monitor monitor in monitorList)
                {
                    monitor.Stop();
                }
            }
            else
            {
                currentMonitor.Stop();
            }
                
        }

        /// <summary>
        /// Everytime a packet is captured, invokes the method OnRefresh.
        /// </summary>
        /// <param name="monitor">Monitor that received this packet.</param>
        /// <param name="p">Packet received.</param>
        private void OnNewPacket(Monitor monitor, Packet p) => Invoke(new refresh(OnRefresh), p);

        private delegate void refresh(Packet p);

        /// <summary>
        /// Updates the DGV with the given packet.
        /// </summary>
        /// <param name="p">Packet received.</param>
        private void OnRefresh(Packet p)
        {
            dataTable.Rows.Add(new object[]
            {
                p.SourceIp, p.SourcePort, p.DestinationIP, p.DestinationPort, p.Protocol, p.Time, p.TotalLength, p.CharString, p.HexString, p.Bytes
            });
            ColorRows();

            if (DGV.Rows.Count != 0 && btnAutomaticScroll.Checked)
            {
                DGV.FirstDisplayedScrollingRowIndex = DGV.RowCount - 1;
            }
        }

        /// <summary>
        /// Sets the filter of the DGV.
        /// </summary>
        private void FilterDGV()
        {
            string filter = tbFilter.Text;
            DataTable dataTable = (DataTable) DGV.DataSource;

            try
            {
                if (string.IsNullOrEmpty(filter))
                {
                    dataTable.DefaultView.RowFilter = "";
                    tbFilter.BackColor = Color.White;
                } 
                else
                {
                    dataTable.DefaultView.RowFilter = filter;
                    tbFilter.BackColor = Color.LimeGreen;
                }
            }
            catch (Exception)
            {
                dataTable.DefaultView.RowFilter = "";
                tbFilter.BackColor = Color.Crimson;
            }
            finally
            {
                ColorRows();
            }
        }

        /// <summary>
        /// Colors all the rows of the DGV depending on the protocol the respective packet uses.
        /// </summary>
        private void ColorRows()
        {
            if (btnPacketColoring.Checked)
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    string protocol = Convert.ToString(row.Cells["Protocol"].Value);

                    switch (protocol)
                    {
                        case "TCP":
                            row.DefaultCellStyle.BackColor = Color.Lavender;
                            break;
                        case "UDP":
                            row.DefaultCellStyle.BackColor = Color.LightCyan;
                            break;
                        case "GGP":
                            row.DefaultCellStyle.BackColor = Color.Aquamarine;
                            break;
                        case "ICMP":
                            row.DefaultCellStyle.BackColor = Color.Bisque;
                            break;
                        case "IDP":
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            break;
                        case "IGMP":
                            row.DefaultCellStyle.BackColor = Color.PaleGreen;
                            break;
                        case "IP":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "ND":
                            row.DefaultCellStyle.BackColor = Color.Thistle;
                            break;
                        case "PUP":
                            row.DefaultCellStyle.BackColor = Color.BlanchedAlmond;
                            break;
                        case "OTHERS":
                            row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                            break;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in DGV.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Sets the current selected row of the DGV.
        /// </summary>
        /// <param name="index">Index of the row to select.</param>
        private void SetSelectedRow(int index)
        {
            if (index >= 0 && index < DGV.RowCount)
            {
                DGV.CurrentCell = DGV.Rows[index].Cells[0];
                DGV_CellClick(this, new DataGridViewCellEventArgs(0, index));
            }
        }

        /// <summary>
        /// Exports all packets to a txt file.
        /// </summary>
        private void ExportPacketsAsText()
        {
            if (DGV.RowCount > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Text Files(*.txt)|*.txt",
                    Title = "Export selected packets as text",
                    FileName = "packets.txt"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.OpenFile()))
                    {
                        sw.WriteLine("---------------------------------------------\n");

                        foreach (DataGridViewRow row in DGV.Rows)
                        {
                            string sourceIP = row.Cells["SourceIp"].Value.ToString();
                            string sourcePort = row.Cells["SourcePort"].Value.ToString();
                            string destinationIP = row.Cells["DestinationIp"].Value.ToString();
                            string destinationPort = row.Cells["DestinationPort"].Value.ToString();
                            string protocol = row.Cells["Protocol"].Value.ToString();
                            string time = row.Cells["Time"].Value.ToString();
                            string length = row.Cells["Length"].Value.ToString();
                            string data = row.Cells["Data"].Value.ToString();

                            sw.WriteLine(string.Format("{0, -20}{1}", "PROTOCOL:", protocol));
                            sw.WriteLine(!string.IsNullOrEmpty(sourcePort) ?
                                string.Format("{0, -20}{1}", "SOURCE:", sourceIP + ":" + sourcePort) :
                                string.Format("{0, -20}{1}", "SOURCE:", sourceIP));
                            sw.WriteLine(!string.IsNullOrEmpty(destinationPort) ?
                                string.Format("{0, -20}{1}", "DESTINATION:", destinationIP + ":" + destinationPort) :
                                string.Format("{0, -20}{1}", "DESTINATION:", destinationIP));
                            sw.WriteLine(string.Format("{0, -20}{1} bytes", "TOTAL LENGTH:", length));
                            sw.WriteLine(string.Format("{0, -20}{1}", "CAPTURE TIME:", time));
                            sw.WriteLine("\nDATA:");
                            sw.WriteLine(data.Length > 0 ?
                                data :
                                "Empty\n");
                            sw.WriteLine("---------------------------------------------\n");
                        }

                        sw.Flush();
                        sw.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("No packets to export", "Export packets as text", default, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Exports the selected packet bytes to a binary file.
        /// </summary>
        private void ExportSelectedPacketAsBinary()
        {
            if (DGV.SelectedRows.Count == 1)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Binary Files(*.bin)|*.bin",
                    Title = "Export packet bytes",
                    FileName = "packet_data.bin"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.OpenFile()))
                    {

                        DataGridViewRow selectedRow = DGV.CurrentRow;
                        byte[] bytes = (byte[]) selectedRow.Cells["Raw"].Value;

                        foreach (byte b in bytes)
                            sw.Write((char)b);

                        sw.Flush();
                        sw.Close();
                    }
                }
            } 
            else
            {
                MessageBox.Show("Select one packet", "Export packet bytes", default, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Exports all packets as CSV.
        /// </summary>
        private void ExportPacketsAsCsv()
        {
            if (DGV.RowCount > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "CSV Files(*.csv)|*.csv",
                    Title = "Export packets as CSV",
                    FileName = "packets.csv"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    int columnCount = DGV.Columns.Count - 2;
                    string columnNames = "";
                    string[] outputCsv = new string[DGV.Rows.Count + 1];
                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += DGV.Columns[i].HeaderText.ToString() + ",";
                    }
                    outputCsv[0] += columnNames;

                    for (int i = 1; (i - 1) < DGV.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            if (j != 7)
                            {
                                outputCsv[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                            }
                            else // Data column
                            {
                                outputCsv[i] += '"' + DGV.Rows[i - 1].Cells[j].Value.ToString().Replace("\n", "") + '"' + ",";
                            }
                        }
                    }

                    File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                }
            } 
            else
            {
                MessageBox.Show("No packets to export", "Export packets as CSV", default, MessageBoxIcon.Warning);
            }
        }

        // EVENTS

        private void Sniffer_Load(object sender, EventArgs e)
        {
            LoadControls();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (StartReceiving())
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                btnExportToText.Enabled = false;
                btnExportToCsv.Enabled = false;
                btnExportBytesFromSelected.Enabled = false;
                cbInterfaces.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopReceiving();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnExportToText.Enabled = true;
            btnExportToCsv.Enabled = true;
            btnExportBytesFromSelected.Enabled = true;
            cbInterfaces.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataTable.Rows.Clear();
            rtbHexadecimal.Text = "";
            rtbChars.Text = "";
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                DataGridViewRow dataRow = DGV.Rows[index];
                rtbHexadecimal.Text = dataRow.Cells["hex"].Value.ToString();
                rtbChars.Text = dataRow.Cells["data"].Value.ToString();
            }
        }

        private void DGV_Sorted(object sender, EventArgs e) => ColorRows();

        private void rtbChars_SelectionChanged(object sender, EventArgs e)
        {
            string dataText = rtbChars.Text;
            string selectedText = rtbChars.SelectedText;
            int selectedLength = selectedText.Length;

            int start0 = rtbChars.SelectionStart - selectedLength;
            int start1 = rtbChars.SelectionStart;

            int index = start0 > -1 && dataText.Substring(start0, selectedLength).Equals(selectedText) ? start0 : start1;
            string tmpString = rtbChars.Text.Substring(0, index);
            int spaceCount = getCharCount(tmpString, '\n');

            int start = tmpString.Length * 3 - 2 * spaceCount;
            int selectedHexLength = rtbChars.SelectedText.Length * 3 - 2 * getCharCount(rtbChars.SelectedText, '\n');
            if (selectedHexLength > 0)
            {
                rtbHexadecimal.SelectionStart = 0;
                rtbHexadecimal.SelectionLength = rtbHexadecimal.Text.Length;
                rtbHexadecimal.SelectionBackColor = Color.White;

                rtbHexadecimal.SelectionStart = start;
                rtbHexadecimal.SelectionLength = selectedHexLength;
                rtbHexadecimal.SelectionBackColor = Color.CornflowerBlue;
            }
            else
            {
                rtbHexadecimal.SelectionBackColor = Color.White;
            }

            int getCharCount(string s, char c)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == c)
                        count++;
                }
                return count;
            }
        }

        private void rtbChars_Leave(object sender, EventArgs e) => rtbHexadecimal.SelectionBackColor = Color.White;

        private void cbProtocol_SelectionChangeCommitted(object sender, EventArgs e) => FilterDGV();

        private void tbFilter_TextChanged(object sender, EventArgs e) => FilterDGV();

        private void btnPrevious_Click(object sender, EventArgs e) => SetSelectedRow(DGV.CurrentRow != null ? DGV.CurrentRow.Index - 1 : 0);

        private void btnNext_Click(object sender, EventArgs e) => SetSelectedRow(DGV.CurrentRow != null ? DGV.CurrentRow.Index + 1 : 0);

        private void btnFirst_Click(object sender, EventArgs e) => SetSelectedRow(0);

        private void btnLast_Click(object sender, EventArgs e) => SetSelectedRow(DGV.RowCount - 1);

        private void btnQuit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnPacketColoring_Click(object sender, EventArgs e) => ColorRows();

        private void btnExportToText_Click(object sender, EventArgs e) => ExportPacketsAsText();

        private void btnExportToCsv_Click(object sender, EventArgs e) => ExportPacketsAsCsv();

        private void btnExportBytesFromSelected_Click(object sender, EventArgs e) => ExportSelectedPacketAsBinary();
    }
}