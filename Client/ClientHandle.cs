using Shared;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client
{
    public class ClientHandle
    {
        Socket clientSocket;
        IPEndPoint localIP;
        IPEndPoint localBroadcast;
        byte[] BUFFER = new byte[1024];

        public ClientHandle(int remotePort, int localPort)
        {
            localBroadcast = new IPEndPoint(IPAddress.Parse("255.255.255.255"), remotePort);
            localIP = new IPEndPoint(IPAddress.Any, localPort);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            clientSocket.EnableBroadcast = true;
        }

        public void InitSocket()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            clientSocket.EnableBroadcast = true;
            clientSocket.Bind(localIP);
        }

        public void Send(ClientBound type, string data)
        {
            if (string.IsNullOrEmpty(data)) return;

            try
            {
                if (!clientSocket.IsBound) clientSocket.Bind(localIP);

                byte[] dataBuff = Encoding.ASCII.GetBytes(data);
                BUFFER[0] = (byte)type;
                dataBuff.CopyTo(BUFFER, 1);

                SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();
                socketAsyncEvent.SetBuffer(BUFFER, 0, dataBuff.Length + 1);
                socketAsyncEvent.RemoteEndPoint = localBroadcast;
                socketAsyncEvent.Completed += OnSuccessSend;

                clientSocket.SendToAsync(socketAsyncEvent);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                throw;
            }
        }

        public void OnSuccessSend(object sender, SocketAsyncEventArgs e)
        {
            SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();
            socketAsyncEvent.SetBuffer(new byte[1024], 0, 1024);
            socketAsyncEvent.RemoteEndPoint = localIP;
            socketAsyncEvent.Completed += Recive;
            clientSocket.ReceiveFromAsync(socketAsyncEvent);
        }

        public void Recive(object sender, SocketAsyncEventArgs e)
        {
            int type = e.Buffer[0];
            string data = Encoding.ASCII.GetString(e.Buffer, 1, e.BytesTransferred);

            switch(type)
            {
                case (int)ServerBound.ON_SUCCESS_LOGIN:
                {
                    Client.OpenChat();
                    break;
                }
            }
        }
    }
}
