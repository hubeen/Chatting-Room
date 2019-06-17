namespace CClient
{
    partial class FrmChatUI
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
            this.tbAllChat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOnlineUser = new System.Windows.Forms.ListBox();
            this.tbChatHere = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbAllChat
            // 
            this.tbAllChat.AutoWordSelection = true;
            this.tbAllChat.BackColor = System.Drawing.SystemColors.Window;
            this.tbAllChat.Location = new System.Drawing.Point(1, 1);
            this.tbAllChat.Name = "tbAllChat";
            this.tbAllChat.ReadOnly = true;
            this.tbAllChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbAllChat.Size = new System.Drawing.Size(634, 285);
            this.tbAllChat.TabIndex = 8;
            this.tbAllChat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Online user";
            // 
            // lstOnlineUser
            // 
            this.lstOnlineUser.FormattingEnabled = true;
            this.lstOnlineUser.ItemHeight = 12;
            this.lstOnlineUser.Location = new System.Drawing.Point(641, 30);
            this.lstOnlineUser.Name = "lstOnlineUser";
            this.lstOnlineUser.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstOnlineUser.Size = new System.Drawing.Size(137, 256);
            this.lstOnlineUser.TabIndex = 12;
            // 
            // tbChatHere
            // 
            this.tbChatHere.Location = new System.Drawing.Point(3, 293);
            this.tbChatHere.Name = "tbChatHere";
            this.tbChatHere.Size = new System.Drawing.Size(632, 21);
            this.tbChatHere.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(640, 292);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(138, 21);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 500;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // FrmChatUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOnlineUser);
            this.Controls.Add(this.tbChatHere);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbAllChat);
            this.Name = "FrmChatUI";
            this.Text = "FrmChatUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChatUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbAllChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOnlineUser;
        private System.Windows.Forms.TextBox tbChatHere;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}