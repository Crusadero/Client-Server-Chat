using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        public void disable()
        {
            this.Hide();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Client._clientHandle = new ClientHandle(8080, int.Parse(Port_textbox.Text));
            Client._clientHandle.Send(ClientBound.LOGIN, $"{Username_textbox.Text} {Password_textbox.Text}");
        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            Client._clientHandle.Send(ClientBound.REGISTER, $"{Username_textbox.Text} {Password_textbox.Text}");
        }
    }
}
