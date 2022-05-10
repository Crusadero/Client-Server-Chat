using Shared;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class ChatServer
    {
        Socket serverSocket;
        IPEndPoint localIP;
        const int PORT = 8080;
        const int BUFFER = 2048;
        List<EndPoint> clients;

        public ChatServer()
        {
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            localIP = new IPEndPoint(IPAddress.Any, PORT);
            serverSocket.EnableBroadcast = true;
            clients = new List<EndPoint>();
        }

        public void WaitNextMessage()
        {
            try
            {
                if (!serverSocket.IsBound) serverSocket.Bind(localIP);
                
                SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();
                socketAsyncEvent.SetBuffer(new byte[BUFFER], 0, BUFFER);
                socketAsyncEvent.RemoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                socketAsyncEvent.Completed += Recive;

                if (!serverSocket.ReceiveFromAsync(socketAsyncEvent))
                {
                    Console.WriteLine("Failed to recive data.");
                    Debug.WriteLine("Failed to recive data.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        private void Recive(object? sender, SocketAsyncEventArgs e)
        {
            int type =  e.Buffer[0];
            string data = Encoding.ASCII.GetString(e.Buffer, 1, e.BytesTransferred);
            Console.WriteLine($"type {type} data {data}");

            switch(type)
            {
                case (int)ClientBound.LOGIN:
                {
                    this.Send((int)ServerBound.ON_SUCCESS_LOGIN, "Success logined!", e.RemoteEndPoint);
                    break;
                }
                case (int)ClientBound.REGISTER:
                {
                    break;
                }
                case (int)ClientBound.BAN:
                {
                    break;
                }
                case (int)ClientBound.MUTE:
                {
                    break;
                }
                case (int)ClientBound.MESSAGE:
                {
                    break;
                }
            }

            WaitNextMessage();
        }

        private void Send(int type, string data, EndPoint remoteEndPoint)
        {
            try
            {
                byte[] buff = new byte[BUFFER];
                byte[] dataBuff = Encoding.ASCII.GetBytes(data);
                buff[0] = (byte)type;
                dataBuff.CopyTo(buff, 1);

                SocketAsyncEventArgs socketAsyncEvent = new SocketAsyncEventArgs();
                socketAsyncEvent.RemoteEndPoint = remoteEndPoint;
                socketAsyncEvent.SetBuffer(buff, 0, dataBuff.Length + 1);
                
                serverSocket.SendToAsync(socketAsyncEvent);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                throw;
            }
        }
    }
}