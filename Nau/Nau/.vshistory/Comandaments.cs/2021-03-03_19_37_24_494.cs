using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Controls03;

namespace Nau
{
    public partial class Comandaments : Form
    {
        public Comandaments()
        {
            InitializeComponent();
        }

        Thread Fil_ping;
        Class1 bbdd = new Class1();
        private void Comandaments_Load(object sender, EventArgs e)
        {
            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(SWComboFK))
                {
                    ctr.DataBindings.Clear();
                    SWComboFK ctr1 = (SWComboFK)ctr;
                    ctr1.CarregarCombo();
                }
            }
            Codificar.Enabled = false;
            //ValidationCode_Codificado.Margin = new Padding(10, 10, 10, 10);
            ValidationCode_Codificado.Text = ValidationCode_Codificado.Text.PadRight(50);
        }

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
        byte[] encryptedData;
        string xmlKey;
        private void CatchKey_Click(object sender, EventArgs e)
        {
            string query = "SELECT ValidationCode FROM InnerEncryption where idPlanet = " + comboPlanet.SelectedValue;
            string taula = "InnerEncryption";
            ValidationCode.Text = bbdd.PortarPerTaula(taula,query).Rows[0][0].ToString();

            string query_key = "SELECT XMLKey FROM PlanetKeys where idPlanet = " + comboPlanet.SelectedValue;
            string taula_key = "PlanetKeys";
            xmlKey = bbdd.PortarPerTaula(taula_key, query_key).Rows[0][0].ToString();

            Codificar.Enabled = true;
        }

        private void Codificar_Click(object sender, EventArgs e)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(ValidationCode.Text);

            RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

            
            rsaEnc.FromXmlString(xmlKey);
            encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);

            ValidationCode_Codificado.Text = ByteConverter.GetString(encryptedData);
        }
    }
}
