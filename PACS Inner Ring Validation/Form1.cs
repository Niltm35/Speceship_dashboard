﻿using System;
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


namespace PACS_Inner_Ring_Validation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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
            string query = "UPDATE InnerEncryption SET idPlanet = "+ comboPlanets.SelectedValue + ", ValidationCode = '" + hola + "' WHERE idPlanet = "+ comboPlanets.SelectedValue + "";
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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            string SELECT_innerencryption = "SELECT * FROM InnerEncryption";
            string TAULA_innerencryption = "InnerEncryption";
            //dataGridView1.DataSource = bbdd.PortarPerTaula(taula, query);
            foreach (Control ctr in Controls)
            {
                if (ctr.GetType() == typeof(SWComboFK))
                {
                    ctr.DataBindings.Clear();
                    SWComboFK ctr1 = (SWComboFK)ctr;
                    ctr1.CarregarCombo();
                    //ctr1.DataBindings.Add("SelectedValue", dataGridView1.DataSource, ctr1.CampId);
                    //ctr1.DataSource = bbdd.PortarPerTaula("Planets", "SELECT idPlanet FROM Planets");
                    //ctr1.DataBindings.Add("SelectedValue", dataGridView1.DataSource, ctr1.CampId);
                }
            }
=======
=======
>>>>>>> Stashed changes
            label1.Text = "SpaceShip Detected!!";
            axWindowsMediaPlayer1.URL = @"Images\tie-fighter6-lento.gif";
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.setMode("loop", true);

            string select_Planet = "SELECT * FROM Planets ORDER BY DescPlanet ASC";
            string taula_Planet = "Planets";
            DataTable dt_Planet = bbdd.PortarPerTaula(taula_Planet, select_Planet);
            comboPlanet.DataSource = dt_Planet;
<<<<<<< Updated upstream

            string select_Nau = "SELECT * FROM SpaceShips ORDER BY idSpaceShip ASC";
            string taula_Nau = "SpaceShips";
            DataTable dt_Nau = bbdd.PortarPerTaula(taula_Nau, select_Nau);
            comboNau.DataSource = dt_Nau;

            string select_Delivery = "SELECT * FROM DeliveryData ORDER BY idDeliveryData ASC";
            string taula_Delivery = "DeliveryData";
            DataTable dt_Delivery = bbdd.PortarPerTaula(taula_Delivery, select_Delivery);
            comboDelivery.DataSource = dt_Delivery;

            //ValidationCode.TextAlign = HorizontalAlignment.Center;
            //Codificar.Enabled = false;
            btn_sendMessage.Enabled = false;


>>>>>>> Stashed changes
=======

            string select_Nau = "SELECT * FROM SpaceShips ORDER BY idSpaceShip ASC";
            string taula_Nau = "SpaceShips";
            DataTable dt_Nau = bbdd.PortarPerTaula(taula_Nau, select_Nau);
            comboNau.DataSource = dt_Nau;

            string select_Delivery = "SELECT * FROM DeliveryData ORDER BY idDeliveryData ASC";
            string taula_Delivery = "DeliveryData";
            DataTable dt_Delivery = bbdd.PortarPerTaula(taula_Delivery, select_Delivery);
            comboDelivery.DataSource = dt_Delivery;

            //ValidationCode.TextAlign = HorizontalAlignment.Center;
            //Codificar.Enabled = false;
            btn_sendMessage.Enabled = false;


>>>>>>> Stashed changes
            //progressBar1.Value = 100;
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

        public byte [] textencrypt_
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
            //progressBar1.ForeColor = Color.Green;
            //progressBar1.BackColor = Color.LightBlue;

            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
<<<<<<< Updated upstream
=======
        
        Thread fil_codificacion_letra;
        Thread fil_codificacion_num;

        private void button1_Click(object sender, EventArgs e)
        {
            int h = 0;
            fil_codificacion_letra = new Thread(generacion_cod_fit);
            fil_codificacion_num = new Thread(generacio_cod_fit_num);
            fil_codificacion_letra.Start();
            fil_codificacion_num.Start();
        }
        

        private void generacion_cod_fit()
        {
            var numero = new Random();

            int aleatori;
            for (char j = 'A'; j <= 'Z'; j++)
            {
                aleatori = numero.Next(0, 999);
                string numero_aleatorio = "";
                if (aleatori.ToString().Length == 2)
                {
                    numero_aleatorio = 0 + aleatori.ToString();
                }
                else if(aleatori.ToString().Length == 1)
                {
                    numero_aleatorio = 00 + aleatori.ToString();
                }
                else
                {
                    numero_aleatorio = aleatori.ToString();
                }

                diccionari.Add(j.ToString(), numero_aleatorio);
            }

            Parallel.For(1, 4, i =>
            {
                string filepath = @"Fitxers\Lletres\" + "PACS" + i + ".txt";
                FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                string lletra = "";
            
                RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
                var byteArray = new byte[4];


                for (int u = 0; u < 100000; u++)
                {
                    provider.GetBytes(byteArray);
                    var randomInteger = BitConverter.ToInt32(byteArray, 0);
                    Random rnd = new Random(randomInteger);
                    int posicio_abc = rnd.Next(0,26);
                    lletra = lletra + diccionari.ElementAt((posicio_abc)).Key; 
                }

                writer.WriteLine(lletra);
                writer.Flush();
                writer.Close();
            });
            fil_codificacion_letra.Abort();
        }
        private void generacio_cod_fit_num()
        {
            fil_codificacion_letra.Join();

            Parallel.For(1, 4, p =>
            {
                string filepath = @"Fitxers\Lletres\" + "PACS" + p + ".txt";
                FileStream lletra_fit = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(lletra_fit);

                string filepath_numeros = @"Fitxers\Numeros\" + "PACS_num" + p + ".txt";
                FileStream fs = new FileStream(filepath_numeros, FileMode.Create, FileAccess.Write, FileShare.Read);
                StreamWriter writer = new StreamWriter(fs);
                string numeros = "";
                string lletra = "";
                bool end = false;

                while (!end)
                {
                    lletra = Convert.ToString((char)reader.Read());
                    if (lletra == "\r")
                    {
                        end = true;
                        writer.WriteLine();
                    }
                    else
                    {
                        writer.Write(diccionari[lletra]);
                    }
                }
                
                writer.Flush();
                writer.Close();
            });


            var zipFile = Application.StartupPath + "\\Fitxers\\PACS.zip";
            var files = Directory.GetFiles(@"Fitxers\Lletres");

            if (File.Exists(zipFile))
            {
                File.Delete(zipFile);
            }
            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                foreach (var fPath in files)
                {
                    archive.CreateEntryFromFile(fPath, Path.GetFileName(fPath));
                }
            }

            fil_codificacion_letra.Abort();
        }

        

        //-----------------CLIENT--------------------------------------
        string IP_Planet;
        string Port_Planet;
        string IP_Nau;
        string Port_Nau;
        Thread Fil_ping;

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
                Listener = new TcpListener(IPAddress.Any, Convert.ToInt32(Port_Planet));
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
                        //message_planet(data);
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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
=======
>>>>>>> Stashed changes

        private void botoN_X1_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void comboNau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port_Nau = TaulaNau().Tables[0].Rows[0][4].ToString();
            IP_Nau = TaulaNau().Tables[0].Rows[0][3].ToString();
        }

        private void comboPlanet_SelectedIndexChanged(object sender, EventArgs e)
        {
            IP_Planet = TaulaPlanet().Tables[0].Rows[0][10].ToString();
            Port_Planet = TaulaPlanet().Tables[0].Rows[0][11].ToString();
        }

        //-----------------FIN SERVIDOR--------------------------------

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
