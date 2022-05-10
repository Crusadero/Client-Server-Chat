using Client.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public static class Client
    {
        public static ClientHandle _clientHandle = null;
        public static Dictionary<string, Form> _forms = new Dictionary<string, Form>();

        public static void OpenChat()
        {

            LoginForm loginForm = (Client._forms["LoginForm"] as LoginForm);
            ChatForm chatForm = (Client._forms["ChatForm"] as ChatForm);

            loginForm.Invoke(new Action(() => {
                loginForm.Hide();
                chatForm.Show();
            }));
        }

        public static void OnChatClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _forms.Add("LoginForm", new LoginForm());
            _forms.Add("ChatForm", new ChatForm());
            (_forms["ChatForm"] as ChatForm).FormClosed += OnChatClose;


            Application.Run(_forms["LoginForm"]);
        }
    }
}
