using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanPartyBeta
{
    public class Container
    {
        public class Friend
        {
            public string IP;
            public string Name;
            public Friend(string ip, string name)
            {
                IP= ip;
                Name= name;
            }
        }
        public class Socks
        {
            public string Out = "";
            public string Last = "";

            const int PORT_NUMBER = 15000;
            List<IPAddress> ipList = new List<IPAddress>();
            public List<Friend> FriendList = new List<Friend>();
            public void localIPAddress()
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());
                
                foreach (IPAddress ip in host.AddressList)
                {
                    ipList.Add(ip);
                }
            }
            public void addFriend(string ip, string name)
            {
                Friend friend = new Friend(ip,name);
                FriendList.Add(friend);
            }
            
            Thread t = null;
            public void Start()
            {
                if (t != null)
                {
                    throw new Exception();
                }
                StartListening();
            }
            public void Stop()
            {
                try
                {
                    udp.Close();
                }
                catch { }
            }

            private readonly UdpClient udp = new UdpClient(PORT_NUMBER);
            IAsyncResult ar_ = null;

            private void StartListening()
            {
                ar_ = udp.BeginReceive(Receive, new object());
            }
            private void Receive(IAsyncResult ar)
            {
                localIPAddress();
                IPEndPoint ip = new IPEndPoint(IPAddress.Any, PORT_NUMBER);
                byte[] bytes = udp.EndReceive(ar, ref ip);
                string message = Encoding.ASCII.GetString(bytes);

                if (ipList.Contains(ip.Address))
                {
                    Out = "";
                    Out += "You";
                    //Out += ip.Address.ToString();
                    Out += ":  ";
                    Out += Convert.ToString(message);
                    Out += "\x0A";
                }
                else
                {
                    Out = "";
                    Out += "From ";
                    Out += ip.Address.ToString();
                    Out += ":  ";
                    Out += Convert.ToString(message);
                    Out += "\x0A";
                }
                foreach (var f in FriendList)
                {
                    if (f.IP.Equals(ip.Address.ToString(), StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (ipList.Contains(ip.Address))
                        {
                            Out = "";
                            Out += f.Name;
                            Out += ":  ";
                            Out += Convert.ToString(message);
                            Out += "\x0A";
                            
                        }
                    }
                }

                StartListening();
            }
            public void Send(string message)
            {
                UdpClient client = new UdpClient();
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse("255.255.255.255"), PORT_NUMBER);
                byte[] bytes = Encoding.ASCII.GetBytes(message);
                client.Send(bytes, bytes.Length, ip);
                client.Close();
            }
        }
    }
}
