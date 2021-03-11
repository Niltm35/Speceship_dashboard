using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls03;
using AccesoDatos;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Threading;
using System.Xml.Linq;
using System.Net.Sockets;
using System.Net;

namespace PACS_Inner_Ring_Validation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //SERVER
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Class1 bbdd = new Class1();
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void ValidationGenerate_button_Click(object sender, EventArgs e)
        {
            string hola = RandomString(10);
            string taula = "InnerEncryption";
            string query = "UPDATE InnerEncryption SET idPlanet = " + comboPlanets.SelectedValue + ", ValidationCode = '" + hola + "' WHERE idPlanet = " + comboPlanets.SelectedValue + "";
            //string query = "INSERT INTO InnerEncryption (idPlanet,ValidationCode) VALUES (1,'" + hola + "')";
            string query1 = "SELECT * FROM InnerEncryption";

            bbdd.PortarPerTaula(taula, query);
            //dataGridView1.DataSource = bbdd.PortarPerTaula(taula,query1);
            //comboBox1.ValueMember = "cLoadName";
            //combobox1.DisplayMember = "cLoadName";
            //combobox1.DataSource = ds;
            //combobox1.DataBind();
        }
        private void Form1_Load(object sender, EventArgs e)
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
            //-----------------SERVER--------------------------------
            btn_sendMessage.Enabled = false;
            //string ini = dd().Tables[0].Rows[0][0].ToString();

            //-----------------FIN SERVER--------------------------------
        }

        private void KeyGenerator_button_Click(object sender, EventArgs e)
        {
            string SELECT_planets = "SELECT CodePlanet FROM Planets where idPlanet = " + comboPlanets.SelectedValue;
            string TAULA_planets = "Planets";
            CspParameters cspp = new CspParameters();
            string keyName = bbdd.PortarPerTaula(TAULA_planets, SELECT_planets).Rows[0][0].ToString();
            cspp.KeyContainerName = keyName;

            //Això genera un parell de claus pública\privada.
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cspp);

            //Salvem la info de les claus en un XML.
            string publicKey = rsa.ToXmlString(false);

            rsa.PersistKeyInCsp = false;
            rsa.Clear();

            string UPDATE_planetkeys = "UPDATE PlanetKeys SET XMLKey = '" + publicKey + "' WHERE idPlanet = '" + comboPlanets.SelectedValue + "'";
            string query2 = "INSERT INTO PlanetKeys (idPlanet,XMLKey) VALUES (" + comboPlanets.SelectedValue + ",'1')";
            string TAULA_planetkeys = "PlanetKey";
            bbdd.PortarPerTaula(TAULA_planetkeys, UPDATE_planetkeys);
        }
        private byte[] textencrypt;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        public byte[] textencrypt_
        {
            get { return textencrypt; }
            set {
                textencrypt = value;
                textBox1.Text = ByteConverter.GetString(textencrypt);
            }
        }

        private void Desencriptar_button_Click(object sender, EventArgs e)
        {
            string SELECT_planets = "SELECT CodePlanet FROM Planets where idPlanet = " + comboPlanets.SelectedValue + " ORDER BY CodePlanet DESC";
            string TAULA_planets = "Planets";
            string keyName = bbdd.PortarPerTaula(TAULA_planets, SELECT_planets).Rows[0][0].ToString();
            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = keyName;
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider(cspParams);

            string privateKey2 = rsaKey.ToXmlString(true);

            rsaKey.PersistKeyInCsp = false;

            byte[] desencrypt = rsaKey.Decrypt(textencrypt_, false);
            textBox2.Text = ByteConverter.GetString(desencrypt);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Blue;
            progressBar1.BackColor = Color.Black;

            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        //-----------------CLIENT--------------------------------
        Thread Fil_ping;
        string IP_Planet;
        string Port_Planet;
        
        public DataSet dd()
        {
            string SELECT = "SELECT * FROM Planets where idPlanet = " + comboPlanets.SelectedValue;
            string TAULA = "Planets";
            DataSet Data_Planet = bbdd.PortarPerConsulta(SELECT, TAULA);
            return Data_Planet;
        }
        private void comboPlanets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IP_Planet = dd().Tables[0].Rows[0][10].ToString();
            Port_Planet = dd().Tables[0].Rows[0][11].ToString();
        }

        private void ping()
        {
            //string IP_Planet = hola.Tables[0].Rows[0][10].ToString();
            //string Puerto_Planet = hola.Tables[0].Rows[0][11].ToString();
            Control.CheckForIllegalCrossThreadCalls = false;
            btn_comprovarXarxa.Enabled = false;
            btn_desconnect.Enabled = false;
            Boolean xarxaDisponible;
            xarxaDisponible = NetworkInterface.GetIsNetworkAvailable();
            //IP_Planet = dd().Rows[0][10].ToString();

            if (xarxaDisponible)
            {
                pnl_status.BackColor = Color.Yellow;

                Ping myPing = new Ping();

                PingReply reply;

                string Estado = "";
                for (int i = 1; i <= 10; i++)
                {
                    reply = myPing.Send(IP_Planet, Convert.ToInt32(Port_Planet));


                    if (reply.Address != null)
                    {
                        Estado = "OK";
                    }
                    else
                    {
                        Estado = "NOK";
                    }
                    lbx_console.Items.Add("Ping" + i + " - " + Estado);
                    Thread.Sleep(100);
                }
                if (Estado.Equals("NOK"))
                {
                    pnl_status.BackColor = Color.Red;
                    btn_comprovarXarxa.Enabled = true;
                    btn_desconnect.Enabled = false;
                    btn_sendMessage.Enabled = false;
                    lb_statusInfo.Text = "Ping no contesta o Xarxa no disponible";
                }
                else
                {
                    pnl_status.BackColor = Color.Green;
                    btn_comprovarXarxa.Enabled = true;
                    btn_desconnect.Enabled = true;
                    btn_sendMessage.Enabled = true;
                    lb_statusInfo.Text = "Connexió correcta";
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

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            try
            {

                TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port_Planet));
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
            txb_ip.Text = "";
            txb_port.Text = "";
            txb_message.Text = "";
            lb_statusInfo.Text = "";
        }

        //-----------------FIN CLIENT--------------------------------
        //-----------------SERVIDOR--------------------------------

        Thread comprobacio_conexio;

        private void btn_connect_serv_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                comprobacio_conexio = new Thread(conexio);
                comprobacio_conexio.Start();
                IsConnected = true;
            }

        }
        Boolean IsConnected;
        TcpClient client;
        TcpListener Listener = null;
        NetworkStream ns;

        public void conexio()
        {
            try
            {
                Listener = new TcpListener(IPAddress.Any, Convert.ToInt32(Port_Planet));
                Listener.Start();

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
                        lbx_Missatges.Items.Add("IP: " + "la Nau" + " ha enviat: " + data);
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




        //-----------------FIN SERVIDOR--------------------------------
    }
}
