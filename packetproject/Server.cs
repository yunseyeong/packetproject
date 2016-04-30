using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
/*
public string viewip()
{
    IPHostEntry server = Dns.GetHostByName(Dns.GetHostName());
    string servip = server.AddressList[0].ToString();
    return servip;
}
*/
namespace packetproject
{
    public partial class Server : Form
    {
        public static string mainip
        {
            get
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                string servip = string.Empty;
                for (int i=0; i< host.AddressList.Length; i++)
                {
                    if(host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        servip = host.AddressList[i].ToString();
                    }
                }
                return servip;
            }
        }
        public Server()
        {

            
            
        }
        //IPHostEntry servip = Dns.GetHostByName(Dns.GetHostName());
        
        private void serveriptext_TextChanged(object sender, EventArgs e)
        {
            IPHostEntry servip = Dns.GetHostEntry(Dns.GetHostName());
            serveriptext.Text = servip.AddressList[0].ToString();
        }
    }
}
