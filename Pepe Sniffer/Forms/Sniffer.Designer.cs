
namespace PepeSniffer
{
    partial class Sniffer
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sniffer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbHexadecimal = new System.Windows.Forms.RichTextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rtbChars = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.myToolbar = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExportToText = new System.Windows.Forms.ToolStripButton();
            this.btnExportToCsv = new System.Windows.Forms.ToolStripButton();
            this.btnExportBytesFromSelected = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.btnAutomaticScroll = new System.Windows.Forms.ToolStripButton();
            this.btnPacketColoring = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.captureSettings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lblInterface = new System.Windows.Forms.Label();
            this.cbInterfaces = new System.Windows.Forms.ComboBox();
            this.SourceIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourcePort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Protocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.myToolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.captureSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.rtbHexadecimal);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.rtbChars);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1073, 195);
            this.panel2.TabIndex = 7;
            // 
            // rtbHexadecimal
            // 
            this.rtbHexadecimal.AutoWordSelection = true;
            this.rtbHexadecimal.BackColor = System.Drawing.Color.White;
            this.rtbHexadecimal.DetectUrls = false;
            this.rtbHexadecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHexadecimal.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHexadecimal.Location = new System.Drawing.Point(0, 0);
            this.rtbHexadecimal.Name = "rtbHexadecimal";
            this.rtbHexadecimal.ReadOnly = true;
            this.rtbHexadecimal.Size = new System.Drawing.Size(762, 195);
            this.rtbHexadecimal.TabIndex = 3;
            this.rtbHexadecimal.Text = "";
            this.rtbHexadecimal.WordWrap = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightGray;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(762, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 195);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // rtbChars
            // 
            this.rtbChars.BackColor = System.Drawing.Color.White;
            this.rtbChars.DetectUrls = false;
            this.rtbChars.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbChars.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.rtbChars.Location = new System.Drawing.Point(764, 0);
            this.rtbChars.Name = "rtbChars";
            this.rtbChars.ReadOnly = true;
            this.rtbChars.Size = new System.Drawing.Size(309, 195);
            this.rtbChars.TabIndex = 1;
            this.rtbChars.Text = "";
            this.rtbChars.WordWrap = false;
            this.rtbChars.SelectionChanged += new System.EventHandler(this.rtbChars_SelectionChanged);
            this.rtbChars.Leave += new System.EventHandler(this.rtbChars_Leave);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.LightGray;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter2.Location = new System.Drawing.Point(0, 461);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(1073, 2);
            this.splitter2.TabIndex = 9;
            this.splitter2.TabStop = false;
            // 
            // myToolbar
            // 
            this.myToolbar.BackColor = System.Drawing.Color.White;
            this.myToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.myToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.myToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart,
            this.btnStop,
            this.btnClear,
            this.toolStripSeparator1,
            this.btnExportToText,
            this.btnExportToCsv,
            this.btnExportBytesFromSelected,
            this.toolStripSeparator3,
            this.btnPrevious,
            this.btnNext,
            this.btnFirst,
            this.btnLast,
            this.btnAutomaticScroll,
            this.btnPacketColoring,
            this.toolStripSeparator2,
            this.btnQuit});
            this.myToolbar.Location = new System.Drawing.Point(0, 0);
            this.myToolbar.Name = "myToolbar";
            this.myToolbar.Size = new System.Drawing.Size(1073, 27);
            this.myToolbar.TabIndex = 10;
            this.myToolbar.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.Image = global::PacketAnalyzer.Properties.Resources.power;
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(24, 24);
            this.btnStart.Text = "Start capturing";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::PacketAnalyzer.Properties.Resources.stop;
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(24, 24);
            this.btnStop.Text = "Stop capture";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = global::PacketAnalyzer.Properties.Resources.clear;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(24, 24);
            this.btnClear.Text = "Clear packets";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnExportToText
            // 
            this.btnExportToText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportToText.Image = global::PacketAnalyzer.Properties.Resources.txt;
            this.btnExportToText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToText.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnExportToText.Name = "btnExportToText";
            this.btnExportToText.Size = new System.Drawing.Size(24, 24);
            this.btnExportToText.Text = "Export all packets to text";
            this.btnExportToText.Click += new System.EventHandler(this.btnExportToText_Click);
            // 
            // btnExportToCsv
            // 
            this.btnExportToCsv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportToCsv.Image = global::PacketAnalyzer.Properties.Resources.csv;
            this.btnExportToCsv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToCsv.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnExportToCsv.Name = "btnExportToCsv";
            this.btnExportToCsv.Size = new System.Drawing.Size(24, 24);
            this.btnExportToCsv.Text = "Export all packets to CSV";
            this.btnExportToCsv.Click += new System.EventHandler(this.btnExportToCsv_Click);
            // 
            // btnExportBytesFromSelected
            // 
            this.btnExportBytesFromSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportBytesFromSelected.Image = global::PacketAnalyzer.Properties.Resources.bin;
            this.btnExportBytesFromSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportBytesFromSelected.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnExportBytesFromSelected.Name = "btnExportBytesFromSelected";
            this.btnExportBytesFromSelected.Size = new System.Drawing.Size(24, 24);
            this.btnExportBytesFromSelected.Text = "Export selected packet bytes";
            this.btnExportBytesFromSelected.Click += new System.EventHandler(this.btnExportBytesFromSelected_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = global::PacketAnalyzer.Properties.Resources.left_arrow;
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 24);
            this.btnPrevious.Text = "Previous packet";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::PacketAnalyzer.Properties.Resources.right_arrow;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 24);
            this.btnNext.Text = "Next packet";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Image = global::PacketAnalyzer.Properties.Resources.up_arrow;
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(24, 24);
            this.btnFirst.Text = "First packet";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Image = global::PacketAnalyzer.Properties.Resources.down_arrow;
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(24, 24);
            this.btnLast.Text = "Last packet";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnAutomaticScroll
            // 
            this.btnAutomaticScroll.Checked = true;
            this.btnAutomaticScroll.CheckOnClick = true;
            this.btnAutomaticScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAutomaticScroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAutomaticScroll.Image = global::PacketAnalyzer.Properties.Resources.scroll_to_last;
            this.btnAutomaticScroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAutomaticScroll.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnAutomaticScroll.Name = "btnAutomaticScroll";
            this.btnAutomaticScroll.Size = new System.Drawing.Size(24, 24);
            this.btnAutomaticScroll.Text = "Automatically scroll to the last packet captured";
            // 
            // btnPacketColoring
            // 
            this.btnPacketColoring.Checked = true;
            this.btnPacketColoring.CheckOnClick = true;
            this.btnPacketColoring.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnPacketColoring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPacketColoring.Image = global::PacketAnalyzer.Properties.Resources.color_packets;
            this.btnPacketColoring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPacketColoring.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnPacketColoring.Name = "btnPacketColoring";
            this.btnPacketColoring.Size = new System.Drawing.Size(24, 24);
            this.btnPacketColoring.Text = "Activate packet coloring";
            this.btnPacketColoring.Click += new System.EventHandler(this.btnPacketColoring_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQuit.Image = global::PacketAnalyzer.Properties.Resources.quit;
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(24, 24);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.DGV);
            this.panel1.Controls.Add(this.captureSettings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 434);
            this.panel1.TabIndex = 11;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.ColumnHeadersHeight = 25;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SourceIp,
            this.SourcePort,
            this.DestinationIp,
            this.DestinationPort,
            this.Protocol,
            this.Time,
            this.Length,
            this.Data,
            this.Hex,
            this.Raw});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.Location = new System.Drawing.Point(0, 28);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.RowTemplate.Height = 20;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1069, 402);
            this.DGV.TabIndex = 7;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            this.DGV.Sorted += new System.EventHandler(this.DGV_Sorted);
            // 
            // captureSettings
            // 
            this.captureSettings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.captureSettings.Controls.Add(this.label1);
            this.captureSettings.Controls.Add(this.tbFilter);
            this.captureSettings.Controls.Add(this.lblInterface);
            this.captureSettings.Controls.Add(this.cbInterfaces);
            this.captureSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.captureSettings.Location = new System.Drawing.Point(0, 0);
            this.captureSettings.Name = "captureSettings";
            this.captureSettings.Size = new System.Drawing.Size(1069, 28);
            this.captureSettings.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filter:";
            // 
            // tbFilter
            // 
            this.tbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilter.Location = new System.Drawing.Point(391, 3);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(675, 23);
            this.tbFilter.TabIndex = 5;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterface.Location = new System.Drawing.Point(3, 7);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(62, 15);
            this.lblInterface.TabIndex = 2;
            this.lblInterface.Text = "Interface:";
            // 
            // cbInterfaces
            // 
            this.cbInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterfaces.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInterfaces.FormattingEnabled = true;
            this.cbInterfaces.Items.AddRange(new object[] {
            "ALL AVAILABLE INTERFACES"});
            this.cbInterfaces.Location = new System.Drawing.Point(71, 3);
            this.cbInterfaces.Name = "cbInterfaces";
            this.cbInterfaces.Size = new System.Drawing.Size(269, 23);
            this.cbInterfaces.TabIndex = 1;
            // 
            // SourceIp
            // 
            this.SourceIp.HeaderText = "Source IP";
            this.SourceIp.MinimumWidth = 6;
            this.SourceIp.Name = "SourceIp";
            this.SourceIp.ReadOnly = true;
            this.SourceIp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SourceIp.Width = 134;
            // 
            // SourcePort
            // 
            this.SourcePort.HeaderText = "Source Port";
            this.SourcePort.MinimumWidth = 6;
            this.SourcePort.Name = "SourcePort";
            this.SourcePort.ReadOnly = true;
            this.SourcePort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SourcePort.Width = 133;
            // 
            // DestinationIp
            // 
            this.DestinationIp.HeaderText = "Destination IP";
            this.DestinationIp.MinimumWidth = 6;
            this.DestinationIp.Name = "DestinationIp";
            this.DestinationIp.ReadOnly = true;
            this.DestinationIp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DestinationIp.Width = 134;
            // 
            // DestinationPort
            // 
            this.DestinationPort.HeaderText = "Destination Port";
            this.DestinationPort.MinimumWidth = 6;
            this.DestinationPort.Name = "DestinationPort";
            this.DestinationPort.ReadOnly = true;
            this.DestinationPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DestinationPort.Width = 134;
            // 
            // Protocol
            // 
            this.Protocol.HeaderText = "Protocol";
            this.Protocol.MinimumWidth = 6;
            this.Protocol.Name = "Protocol";
            this.Protocol.ReadOnly = true;
            this.Protocol.Width = 133;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 134;
            // 
            // Length
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Length.DefaultCellStyle = dataGridViewCellStyle2;
            this.Length.HeaderText = "Length";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 133;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Hex
            // 
            this.Hex.HeaderText = "Hex";
            this.Hex.Name = "Hex";
            this.Hex.ReadOnly = true;
            this.Hex.Visible = false;
            // 
            // Raw
            // 
            this.Raw.HeaderText = "Raw";
            this.Raw.Name = "Raw";
            this.Raw.ReadOnly = true;
            this.Raw.Visible = false;
            // 
            // Sniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myToolbar);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sniffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pepe Sniffer";
            this.Load += new System.EventHandler(this.Sniffer_Load);
            this.panel2.ResumeLayout(false);
            this.myToolbar.ResumeLayout(false);
            this.myToolbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.captureSettings.ResumeLayout(false);
            this.captureSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbChars;
        private System.Windows.Forms.RichTextBox rtbHexadecimal;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStrip myToolbar;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Panel captureSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.ComboBox cbInterfaces;
        private System.Windows.Forms.ToolStripButton btnExportToText;
        private System.Windows.Forms.ToolStripButton btnExportBytesFromSelected;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnAutomaticScroll;
        private System.Windows.Forms.ToolStripButton btnPacketColoring;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnExportToCsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourcePort;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protocol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raw;
    }
}

