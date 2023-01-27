using System;
using System.Net;
using System.Net.Sockets;

namespace PepeSniffer
{
    class Monitor
    {
        private const int BUF_SIZE = 1024 * 1024;

        private Socket socket;
        private readonly IPAddress ipAddress;
        private readonly byte[] buffer;

        public Monitor(IPAddress ip)
        {
            ipAddress = ip;
            buffer = new byte[BUF_SIZE];
        }

        ~Monitor()
        {
            Stop();
        }

        public void Start()
        {
            if (socket == null)
            {
                try
                {
                    if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Raw, ProtocolType.IP);
                    }
                    else
                    {
                        socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Raw, ProtocolType.IP);
                    }
                    socket.Bind(new IPEndPoint(ipAddress, 0));
                    socket.IOControl(IOControlCode.ReceiveAll, BitConverter.GetBytes(1), null);
                    socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
                }
                catch (Exception)
                {
                    Stop();
                    throw;
                }
            }
        }

        public void Stop()
        {
            socket?.Close();
            socket = null;
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                if (socket != null)
                {
                    int len = socket.EndReceive(ar);
                    byte[] receivedBuffer = new byte[len];
                    Array.Copy(buffer, 0, receivedBuffer, 0, len);

                    try
                    {
                        Packet packet = new Packet(receivedBuffer);
                        OnNewPacket(packet);
                    }
                    catch (ArgumentNullException ane)
                    {
                        Console.WriteLine(ane.ToString());
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.ToString());
                    }
                }

                socket?.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(OnReceive), null);
            }
            catch
            {
                Stop();
            }
        }

        protected void OnNewPacket(Packet p)
        {
            PacketEventHandler?.Invoke(this, p);
        }

        public event NewPacketEventHandler PacketEventHandler;

        public delegate void NewPacketEventHandler(Monitor monitor, Packet p);

    }
}