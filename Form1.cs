using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace LanPartyBeta
{
    public partial class Form1 : Form
    {
        Container.Socks udp = new Container.Socks();

        public Form1()
        {
            udp.Start();
            Thread thread = new Thread(new ThreadStart(UpdateTextBoxThread));
            thread.Start();
            InitializeComponent();
        }

        public void UpdateTextBoxThread()
        {
            while (true)
            {
                if (udp.Out != udp.Last) // check for spam
                {
                    richTextBox1.Invoke(() => richTextBox1.AppendText(Convert.ToString(udp.Out)));
                    udp.Last= udp.Out;
                } 
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            udp.Send(Convert.ToString(msgOut.Text));
            msgOut.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            string name = txtFriendName.Text;
            string ip = txtFriendIp.Text;
            udp.addFriend(ip, name);
            richTextBox2.Clear();
            foreach (var f in udp.FriendList)
            {
                
                richTextBox2.AppendText(f.Name);
                richTextBox2.AppendText(": ");
                richTextBox2.AppendText(f.IP);
                richTextBox2.AppendText("\n");
            }
            txtFriendName.Clear();
            txtFriendIp.Clear();
        }

        private void btnRemoveFriend_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            try
            {
                foreach (var f in udp.FriendList)
                {
                    if (f.Name == txtRmName.Text)
                    {
                        udp.FriendList.Remove(f);
                    }
                }

            }
            catch
            {

            }
            foreach (var f in udp.FriendList)
            {
                richTextBox2.AppendText(f.Name);
                richTextBox2.AppendText(": ");
                richTextBox2.AppendText(f.IP);
                richTextBox2.AppendText("\n");
            }
        }
    }
}