using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CClient
{
    public partial class FrmJoin : Form
    {
        TcpChannel chatnul;
        ArrayList OnlineUser = new ArrayList();
        FrmChatUI objChatUI;

        public FrmJoin()
        {
            InitializeComponent();
        }

        private void JoinToRoom()
        {
            string URI = "tcp://" + tbIP.Text + ":8080/" + tbRoomName.Text;

            if (chatnul == null && tbName.Text.Trim().Length != 0)
            {
                chatnul = new TcpChannel();
                ChannelServices.RegisterChannel(chatnul, false);

                objChatUI = new FrmChatUI();
                objChatUI.remoteobj = (RemoteObj.Remoted)Activator.GetObject(typeof(RemoteObj.Remoted), URI); //"tcp://" + tbIP + ":1998" + "/" + tbRoomName);

                if (!objChatUI.remoteobj.JoinToChatRoom(tbName.Text))
                {
                    MessageBox.Show(tbName.Text + "라는 닉네임이 이미 방에 있습니다.\n다른것으로 변경해주세요!");
                    ChannelServices.UnregisterChannel(chatnul);
                    chatnul = null;
                    objChatUI.Dispose();
                    return;
                }
                objChatUI.key = objChatUI.remoteobj.CurrentKey();

                objChatUI.Yname = tbName.Text;

                this.Hide();
                objChatUI.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JoinToRoom();
        }
    }
}
