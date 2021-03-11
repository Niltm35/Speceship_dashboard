using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
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
            string select_Planet = "SELECT * FROM Planets ORDER BY DescPlanet ASC";
            string taula_Planet = "Planets";
            DataTable dt_Planet = bbdd.PortarPerTaula(taula_Planet, select_Planet);
            comboPlanet.DataSource = dt_Planet;

            string select_Nau = "SELECT * FROM SpaceShips ORDER BY DescPlanet ASC";
            string taula_Nau = "SpaceShips";
            DataTable dt_Nau = bbdd.PortarPerTaula(taula_Nau, select_Nau);
            comboPlanet.DataSource = dt_Nau;

            string select_Delivery = "SELECT * FROM DeliveryData ORDER BY DescPlanet ASC";
            string taula_Delivery = "DeliveryData";
            DataTable dt_Delivery = bbdd.PortarPerTaula(taula_Delivery, select_Delivery);
            comboPlanet.DataSource = dt_Delivery;


            Codificar.Enabled = false;
            btn_sendMessage.Enabled = false;
            IP_Planet = TaulaPlanet().Tables[0].Rows[0][10].ToString();
            Port_Planet = TaulaPlanet().Tables[0].Rows[0][11].ToString();
            Port_Nau = TaulaNau().Tables[0].Rows[0][4].ToString();
            IP_Nau = TaulaNau().Tables[0].Rows[0][3].ToString();
        }

        byte[] encryptedData;
        string xmlKey;

        private void CatchKey_Click(object sender, EventArgs e)
        {
            string query = "SELECT ValidationCode FROM InnerEncryption where idPlanet = " + p.SelectedValue;
            string taula = "InnerEncryption";
            ValidationCode.Text = bbdd.PortarPerTaula(taula,query).Rows[0][0].ToString();

            string query_key = "SELECT XMLKey FROM PlanetKeys where idPlanet = " + p.SelectedValue;
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

        public void CarregarComboPlaeta()
        {
            string taula = "planeta";
            DataTable dt = bbdd.PortarPerTaula(taula);
            //c.DataSource = dt;
            //this.DisplayMember = this.CampMostrar;
            //this.ValueMember = this.CampId;

        }

        //-----------------CLIENT--------------------------------------
        string IP_Planet;
        string Port_Planet;
        string IP_Nau;
        string Port_Nau;

        public DataSet TaulaPlanet()
        {
            string SELECT = "SELECT * FROM Planets where idPlanet = " + comboPlanet.SelectedValue;
            string TAULA = "Planets";
            DataSet Data_Planet = bbdd.PortarPerConsulta(SELECT, TAULA);
            return Data_Planet;
        }
        public DataSet TaulaNau()
        {
            string SELECT = "SELECT * FROM SpaceShips where idSpaceShip = " + comboNau.SelectedValue;
            string TAULA = "SpaceShips";
            DataSet Data_Nau = bbdd.PortarPerConsulta(SELECT, TAULA);
            return Data_Nau;
        }
        public DataSet TaulaDelivery()
        {
            string SELECT = "SELECT * FROM DeliveryData where idDeliveryData = " + comboDelivery.SelectedValue;
            string TAULA = "DeliveryData";
            DataSet Data_Delivery = bbdd.PortarPerConsulta(SELECT, TAULA);
            return Data_Delivery;
        }

        private void comboPlanets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IP_Planet = TaulaPlanet().Tables[0].Rows[0][10].ToString();
            Port_Planet = TaulaPlanet().Tables[0].Rows[0][11].ToString();
        }

        private void ping()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            btn_comprovarXarxa.Enabled = false;
            btn_desconnect.Enabled = false;
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
                    reply = myPing.Send("8.8.8.8", Convert.ToInt32("8080"));

                    if (reply.Address != null)
                    {
                        Estado = "OK";
                    }
                    else
                    {
                        Estado = "NOK";
                    }
                    lbx_console.Items.Add("Ping " + i + " - " + Estado);
                    Thread.Sleep(100);
                }
                if (Estado.Equals("NOK"))
                {
                    pnl_status.BackColor = Color.Red;
                    btn_comprovarXarxa.Enabled = true;
                    btn_desconnect.Enabled = false;
                }
                else
                {
                    pnl_status.BackColor = Color.Green;
                    btn_comprovarXarxa.Enabled = true;
                    btn_desconnect.Enabled = true;
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
            btn_sendMessage.Enabled = true;
            btn_desconnect.Enabled = true;
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient client = new TcpClient(IP_Nau, Convert.ToInt32(Port_Nau));
                if (txb_message.Text == "")
                {
                    MessageBox.Show("El missatge no por estar buit");
                }
                else
                {
                    Byte[] dades = Encoding.ASCII.GetBytes(txb_message.Text);
                    NetworkStream ns = client.GetStream();
                    ns.Write(dades, 0, dades.Length);
                }
            }
            catch
            {
                MessageBox.Show("Servidor inaccessible");
            }
        }

        private void btn_desconnect_Click(object sender, EventArgs e)
        {
            if (this.Fil_ping != null)
            {
                Fil_ping.Abort();
            }
            pnl_status.BackColor = Color.Red;
            lbx_console.Items.Clear();
            txb_message.Text = "";
            btn_sendMessage.Enabled = false;
            btn_desconnect.Enabled = false;
        }

        //-----------------FIN CLIENT----------------------------------
        //-----------------SERVIDOR------------------------------------

        Thread comprobacio_conexio;

        private void btn_connect_serv_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                comprobacio_conexio = new Thread(conexio);
                comprobacio_conexio.Start();
                IsConnected = true;
                label1.Text = "Conectado";
            }
        }
        Boolean IsConnected;
        TcpClient client;
        TcpListener Listener = null;
        NetworkStream ns;

        public string LocalIPAddress() 
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        public void conexio()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, Convert.ToInt32(Port_Nau));
                Listener.Start();
                //string gg = LocalIPAddress();
                while (IsConnected)
                {
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        ns = client.GetStream();
                        Byte[] buffer = new byte[256];

                        string data = "";
                        ns.Read(buffer, 0, buffer.Length);
                        data = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                        lbx_Missatges.Items.Add("IP la Nau ha enviat: " + data);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_desconnect_serv_Click(object sender, EventArgs e)
        {
            lbx_Missatges.Items.Clear();
            cerrar();
            label1.Text = "Desconectado";
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrar();
        }

        public void cerrar()
        {
            IsConnected = false;
            if (this.comprobacio_conexio != null)
            {
                comprobacio_conexio.Abort();
            }

            if (this.Listener != null)
            {
                Listener.Stop();
            }

            if (this.client != null)
            {
                client.Close();
            }

            if (this.ns != null)
            {
                ns.Close();
            }
        }

        private void comboNau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Port_Nau = TaulaNau().Tables[0].Rows[0][4].ToString();
        }

        private void botoN_X1_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        //-----------------FIN SERVIDOR--------------------------------
        private void btn_peticion_Click(object sender, EventArgs e)
        {
            string tipo = "ER";
            string code_Nau = TaulaNau().Tables[0].Rows[2].ToString();
            string code_Delivery = "";
            missatge.Text = "";
        }
    }
}
