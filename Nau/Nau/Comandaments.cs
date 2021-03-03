using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nau
{
    public partial class Comandaments : Form
    {
        public Comandaments()
        {
            InitializeComponent();
        }

        Thread Fil_ping;

        private void ping()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Boolean xarxaDisponible;
            xarxaDisponible = NetworkInterface.GetIsNetworkAvailable();

            if (xarxaDisponible)
            {
                pnl_status.BackColor = Color.Yellow;
                Ping myPing = new Ping();

                PingReply reply;
                string Estado = "";

                for (int i = 1; i <= 10; i++)
                {
                    reply = myPing.Send("8.8.8.8", 1000);

                    if (reply.Address != null)
                    {
                        Estado = "OK";

                    }
                    else
                    {
                        Estado = "NOK";
                    }
                    lbx_console.Items.Add("Ping" + i + " - " + Estado);
                    Thread.Sleep(500);

                }

                if (Estado == "OK")
                {
                    pnl_status.BackColor = Color.Green;

                }
                else
                {
                    pnl_status.BackColor = Color.Red;
                }
            }
            else
            {
                pnl_status.BackColor = Color.Red;
            }

        }

        private void btn_comprovarXarxa_Click(object sender, EventArgs e)
        {
            lbx_console.Items.Clear();

            Fil_ping = new Thread(ping);
            Fil_ping.Start();
        }
    }
}
