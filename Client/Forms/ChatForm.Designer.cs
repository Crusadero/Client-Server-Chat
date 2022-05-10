namespace Client.Forms
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Chats_listBox = new System.Windows.Forms.ListBox();
            this.OpenConfirmPalen_button = new System.Windows.Forms.Button();
            this.PendingUsers_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Send_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chats_listBox
            // 
            this.Chats_listBox.FormattingEnabled = true;
            this.Chats_listBox.Location = new System.Drawing.Point(12, 25);
            this.Chats_listBox.Name = "Chats_listBox";
            this.Chats_listBox.Size = new System.Drawing.Size(125, 342);
            this.Chats_listBox.TabIndex = 0;
            // 
            // OpenConfirmPalen_button
            // 
            this.OpenConfirmPalen_button.Location = new System.Drawing.Point(12, 399);
            this.OpenConfirmPalen_button.Name = "OpenConfirmPalen_button";
            this.OpenConfirmPalen_button.Size = new System.Drawing.Size(125, 40);
            this.OpenConfirmPalen_button.TabIndex = 1;
            this.OpenConfirmPalen_button.Text = "button1";
            this.OpenConfirmPalen_button.UseVisualStyleBackColor = true;
            // 
            // PendingUsers_label
            // 
            this.PendingUsers_label.Location = new System.Drawing.Point(12, 369);
            this.PendingUsers_label.Name = "PendingUsers_label";
            this.PendingUsers_label.Size = new System.Drawing.Size(125, 26);
            this.PendingUsers_label.TabIndex = 2;
            this.PendingUsers_label.Text = "Users what pending regestration confirm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chats";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(629, 342);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 373);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(530, 35);
            this.textBox2.TabIndex = 7;
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(679, 373);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(92, 34);
            this.Send_Button.TabIndex = 8;
            this.Send_Button.Text = "Send";
            this.Send_Button.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 451);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PendingUsers_label);
            this.Controls.Add(this.OpenConfirmPalen_button);
            this.Controls.Add(this.Chats_listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Chats_listBox;
        private System.Windows.Forms.Button OpenConfirmPalen_button;
        private System.Windows.Forms.Label PendingUsers_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Send_Button;
    }
}