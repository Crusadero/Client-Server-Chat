using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public static class Server
    {
        public static void Main()
        {
            ChatServer _chatServer = new ChatServer();
            _chatServer.WaitNextMessage();

            while (true) { };
        }
    }
}