using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CClient
{
    public partial class FrmChatUI : Form
    {
        internal RemoteObj.Remoted remoteobj;
        internal int key = 0;
        internal string Yname;
        ArrayList OnlineUser = new ArrayList();

        public FrmChatUI()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }
        int skipCount = 4;

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            if (remoteobj != null)
            {
                string tmpStr = remoteobj.GetMsg(key);
                if (tmpStr.Trim().Length > 0)
                {
                    key++;
                    tbAllChat.Text = tbChatHere.Text + "\n" + tmpStr;
                }
                {
                    ArrayList OnlineUser = remoteobj.GetOnlineList();
                    lstOnlineUser.DataSource = OnlineUser;
                    skipCount = 0;

                    if (OnlineUser.Count < 2)
                    {
                        tbChatHere.Text = "채팅방에 최대 2명이 있어야 활성화 됩니다.";
                        tbChatHere.Enabled = false;
                    }
                    else if (tbChatHere.Text == "채팅방에 최대 2명이 있어야 활성화 됩니다." && tbChatHere.Enabled == false)
                    {
                        tbChatHere.Text = "";
                        tbChatHere.Enabled = true;
                    }
                }

            }
            
        }

        private void SendMessage()
        {
            if (remoteobj != null && tbChatHere.Text.Trim().Length > 0)
            {
                remoteobj.SendMessage(Yname + " : " + tbChatHere.Text);
                tbChatHere.Text = "";
            }
        }

        private void FrmChatUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (remoteobj != null)
            {
                remoteobj.LeaveChatRoom(Yname);
                tbChatHere.Text = "";
            }
            Application.Exit();
        }

        
    }
}
