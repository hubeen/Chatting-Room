using System;
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

namespace CServer
{
    public partial class FrmMainS : Form
    {
        TcpChannel chatnul;

        public FrmMainS()
        {
            InitializeComponent();
        }

        private void btOneClick_Click(object sender, EventArgs e)
        {
            if (btOneClick.Text == "Start")
            {
                if (chatnul == null)
                {
                    chatnul = new TcpChannel(8080);
                    ChannelServices.RegisterChannel(chatnul, false);
                    RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteObj.Remoted), tbChatname.Text, WellKnownObjectMode.Singleton);

                    this.Text = "Running!";
                    btOneClick.Text = "Stop";
                }
                
            }
            else
            {
                if (chatnul != null)
                {
                    ChannelServices.UnregisterChannel(chatnul);
                    chatnul = null;

                    this.Text = "Stoped!";
                    btOneClick.Text = "Start";
                }
                
            }
        }
    }
}
