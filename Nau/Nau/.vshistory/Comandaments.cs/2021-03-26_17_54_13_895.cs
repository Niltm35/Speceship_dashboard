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
using System.Resources;
using System.IO.Compression;

namespace Nau
{
    public partial class Comandaments : Form
    {
        public Comandaments()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        Thread Fil_ping;
        Class1 bbdd = new Class1();
        
        string Name_Planet;
        

        private void Comandaments_Load(object sender, EventArgs e)
        {
            string select_Planet = "SELECT * FROM Planets ORDER BY DescPlanet ASC";
            string taula_Planet = "Planets";
            DataTable dt_Planet = bbdd.PortarPerTaula(taula_Planet, select_Planet);
            comboPlanet.DataSource = dt_Planet;

            string select_Nau = "SELECT * FROM SpaceShips ORDER BY idSpaceShip ASC";
            string taula_Nau = "SpaceShips";
            DataTable dt_Nau = bbdd.PortarPerTaula(taula_Nau, select_Nau);
            comboNau.DataSource = dt_Nau;

            string select_Delivery = "SELECT * FROM DeliveryData ORDER BY idDeliveryData ASC";
            string taula_Delivery = "DeliveryData";
            DataTable dt_Delivery = bbdd.PortarPerTaula(taula_Delivery, select_Delivery);
            comboDelivery.DataSource = dt_Delivery;

            img_server.BackgroundImage = Image.FromFile(Application.StartupPath + @"\imatges\serv_off.png");
            Serv_On.Enabled = true;
            Serv_Off.Enabled = false;

            Codificar.Enabled = false;
            btn_sendMessage.Enabled = false;
            btn_peticion.Enabled = false;
            Send_PublicKey.Enabled = false;
            btn_desconnect.Enabled = true;
        }

        private void botoN_X1_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form frm2 = this.FindForm();
            frm2.Close();

            bool exist = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Nau")
                {
                    exist = true;
                    frm.Show();
                }
            }
        }

        private void comboNau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Port_Nau = TaulaNau().Tables[0].Rows[0][4].ToString();
            Port1_Nau = TaulaNau().Tables[0].Rows[0][5].ToString();
            IP_Nau = TaulaNau().Tables[0].Rows[0][3].ToString();
        }

        private void comboPlanet_SelectedIndexChanged(object sender, EventArgs e)
        {
            IP_Planet = TaulaPlanet().Tables[0].Rows[0][10].ToString();
            Port_Planet = TaulaPlanet().Tables[0].Rows[0][11].ToString();
            Port1_Planet = TaulaPlanet().Tables[0].Rows[0][12].ToString();
            Name_Planet = TaulaPlanet().Tables[0].Rows[0][2].ToString();
            img_planet.BackgroundImage = Image.FromFile(Application.StartupPath + @"\imatges\planets\" + Name_Planet + ".png");
        }

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

        string VK_codificada;
        string xmlKey;
        byte[] encryptedData;

        private void Codificar_Click(object sender, EventArgs e)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(ValidationCode.Text);

            RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

            rsaEnc.FromXmlString(xmlKey);
            encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);

            VK_codificada = ByteConverter.GetString(encryptedData);

            ValidationCode_Codificado.Text = VK_codificada;
            Send_PublicKey.Enabled = true;
        }

        private void btn_peticion_Click(object sender, EventArgs e)
        {
            string type = "ER";
            string code_Nau = TaulaNau().Tables[0].Rows[0][2].ToString();
            string code_Delivery = TaulaDelivery().Tables[0].Rows[0][1].ToString();
            string ER_ms = type + code_Nau + code_Delivery;
            SendMessage(ER_ms);
        }


        //-----------------------------------------------------------------------------------------------------------
        //----------------- CLIENT ----------------------------------------------------------------------------------

        string IP_Planet;
        string Port_Planet;
        string Port1_Planet;
        string IP_Nau;
        string Port_Nau;
        string Port1_Nau;

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
        public DataSet TaulaDescodificar(string codi_letra)
        {
            string SELECT = "SELECT Word FROM InnerEncryptionData where Numbers = '" + codi_letra + "' AND IdInnerEncryption = '" + comboPlanet.SelectedValue + "'";
            string TAULA = "InnerEncryptionData";
            DataSet Data_Delivery = bbdd.PortarPerConsulta(SELECT, TAULA);
            return Data_Delivery;
        }

        private void ping()
        {
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
                    lbx_console.Items.Add("   Ping " + i + "  -  " + Estado);
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
            btn_peticion.Enabled = true;
        }

        //----------------------COMUNICAION CON EL PLANETA-------------------------------------------
        string Smessage;
        string info_warring;

        private void SendMessage(string Smessage)
        {
            try
            {
                TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port_Planet));
                Byte[] dades = Encoding.ASCII.GetBytes(Smessage);
                NetworkStream ns = client.GetStream();
                ns.Write(dades, 0, dades.Length);
                lbx_Missatges.Items.Add("YOU: " + Smessage);
            }
            catch
            {
                //MessageBox.Show("Servidor inaccessible");
                info_warring = "Servidor inaccessible";
                Warning _warning = new Warning();
                _warning.INFO = info_warring;
                _warning.Show();
            }
        }

        private void SendVK(byte[] dades)
        {
            TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port1_Planet));
            NetworkStream ns = client.GetStream();
            ns.Write(dades, 0, dades.Length);
        }

        Thread SendPort1;

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                sendPort();
                SendPort1 = new Thread(sendPort1);
                SendPort1.Start();
            }
            catch
            {
                //MessageBox.Show("Servidor inaccessible");
                info_warring = "Servidor inaccessible";
                Warning _warning = new Warning();
                _warning.INFO = info_warring;
                _warning.Show();
            }
        }

        public void sendPort()
        {
            TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port_Planet));
            if (txb_message.Text == "")
            {
                //MessageBox.Show("El missatge no por estar buit");
                info_warring = "El missatge no por estar buit";
                Warning _warning = new Warning();
                _warning.INFO = info_warring;
                _warning.Show();
            }
            else
            {
                Byte[] dades = Encoding.ASCII.GetBytes(txb_message.Text);
                NetworkStream ns = client.GetStream();
                ns.Write(dades, 0, dades.Length);
                lbx_Missatges.Items.Add("YOU: " + txb_message.Text);
            }
        }

        public void sendPort1()
        {
            TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port1_Planet));
            NetworkStream ns_zip = client.GetStream();

            string zipFile = Application.StartupPath + @"\Fitxers\PACS_m.zip";
            byte[] SendingBuffer = null;
            var BufferSize = 50024;
            FileStream Fs = new FileStream(zipFile, FileMode.Open, FileAccess.Read);

            int NoOfPackets = Convert.ToInt32
            (Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
            int TotalLength = (int)Fs.Length, CurrentPacketLength;

            for (int i = 0; i < NoOfPackets; i++)
            {
                if (TotalLength > BufferSize)
                {
                    CurrentPacketLength = BufferSize;
                    TotalLength = TotalLength - CurrentPacketLength;
                }
                else
                    CurrentPacketLength = TotalLength;
                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                
                ns_zip.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
            }
            Fs.Close();
            ns_zip.Close();
        }

        public void message_planet(string ms)
        {
            string request = ms.Substring(0, 2);
            string answer = ms.Substring(14, 2);

            if (request == "VR")
            {
                if (answer == "VP")
                {
                    string Message = "Validation ln Progress";
                    Info _info = new Info();
                    _info.INFO = Message;
                    _info.ICON = "info_icon.png";
                    _info.Show();

                }
                else if (answer == "AD")
                {
                    string Message = "Access Denied";
                    Info _info = new Info();
                    _info.ICON = "info_icon.png";
                    _info.INFO = Message;
                    _info.Show();
                }
                else if (answer == "AG")
                {
                    MessageBox.Show("Access Granted");
                    string Message = "Access Denied";
                    Info _info = new Info();
                    _info.ICON = "error1.png";
                    _info.INFO = Message;
                    _info.Show();
                }
                else
                {
                    string Message = "Error message: " + ms;
                    Warning _warning = new Warning();
                    _warning.INFO = Message;
                    _warning.Show();
                }
            }
            else
            {
                string Message = "Error message: " + ms;
                //Warning _warning = new Warning();
                //_warning.INFO = Message;
                //_warning.Show();
            }
        }

        private void Send_PublicKey_Click(object sender, EventArgs e)
        {
            Smessage = "VK has been sent";
            SendMessage(Smessage);
            Thread.Sleep(1000);
            SendVK(encryptedData);
        }
        Thread Descodificar;
        private void btn_des_zip_Click(object sender, EventArgs e)
        {
            Descodificar = new Thread(descodificacion_zip);
            Descodificar.Start();
        }

        private void descodificacion_zip()
        {
            string extractPath = Application.StartupPath + @"\Fitxers\PACS_nau";

            //ZipFile.ExtractToDirectory(zipPath, extractPath);

            int n = 1;
            //StreamReader lector = new StreamReader(extractPath + "PACS" + n);
            StreamWriter sw = new StreamWriter(extractPath + "_des.txt", true, Encoding.ASCII);

            string text = File.ReadAllText(extractPath + "\\PACS1.txt");
            //string txt_descod = "";
            
            int leido = 0;

            ////////////////////////
            //FileStream fs = new FileStream(extractPath, FileMode.Create, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(fs);
            //fs = new FileStream(extractPath, FileMode.Append, FileAccess.Write, FileShare.Read);
            //writer = new StreamWriter(fs);
            ///////////////////////
            

            Parallel.For(0, text.Length, i =>
            {
                while (leido < text.Length)
                {
                    string codi = text.Substring(leido, 3);

                    //string SELECT = "SELECT Word FROM InnerEncryptionData where Numbers = '" + codi + "' AND IdInnerEncryption = '" + comboPlanet.SelectedValue + "'";
                    //string TAULA = "InnerEncryptionData";
                    //string letra = bbdd.PortarPerConsulta(SELECT).Tables[0].Rows[0][0].ToString();

                    //string letra = "a";

                    string letra = TaulaDescodificar(codi).Tables[0].Rows[0][0].ToString();

                    sw.Write(letra);
                    sw.Flush();
                    //letra = "";
                    leido = leido + 3;
                    desc_bar.Value = +1;
                }
            });
            sw.Close();
            MessageBox.Show("fin.");
        }

        //---------------------- FIN COMUNICAION CON EL PLANETA ----------------------------------------------------------

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

        //----------------- FIN CLIENT -----------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------
        //----------------- SERVIDOR -------------------------------------------------------------------------------------

        Thread comprobacio_conexio;
        TcpListener Listener = null;
        TcpListener Listener2 = null;
        NetworkStream ns;
        NetworkStream ns_zip;
        Boolean IsConnected;

        private void btn_connect_serv_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                comprobacio_conexio = new Thread(conexio);
                comprobacio_conexio.Start();
                IsConnected = true;
                img_server.BackgroundImage = Image.FromFile(Application.StartupPath + @"\imatges\serv_on2.png");
                Serv_On.Enabled = false;
                Serv_Off.Enabled = true;
            }
        }
        
        Thread ConexioPort;
        Thread ConexioPort1;
        public void conexio()
        {
            try
            {
                ConexioPort = new Thread(conexionPort);
                ConexioPort.Start();
                ConexioPort1 = new Thread(conexionPort1);
                ConexioPort1.Start();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                Warning _warning = new Warning();
                _warning.INFO = Message;
                _warning.Show();
            }
        }

        public void conexionPort()
        {
            Listener = new TcpListener(IPAddress.Any, Convert.ToInt32(Port_Nau));
            Listener.Start();
            TcpClient client;
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
                    lbx_Missatges.Items.Add("PLANET: " + data);
                    message_planet(data);
                }
            }
        }

        //------------ RECIBIR FITCHEROS ZIP ---------------------------------------------------------------------------------

        string zipPath = Application.StartupPath + @"\Fitxers\PACS.zip";
        public void conexionPort1()
        {
            int BufferSize = 1024;
            byte[] RecData = new byte[BufferSize];
            int RecBytes;
            TcpClient clientF = null;
            Listener2 = new TcpListener(IPAddress.Any, Convert.ToInt32(Port1_Nau));
            Listener2.Start();
            while (IsConnected)
            {
                if (Listener2.Pending())
                {
                    clientF = Listener2.AcceptTcpClient();
                    ns_zip = clientF.GetStream();
                    Byte[] buffer_zip = new byte[1024];

                    string SaveFileName = string.Empty;

                    int totalrecbytes = 0;
                    FileStream Fs = new FileStream(zipPath, FileMode.OpenOrCreate, FileAccess.Write);
                    while ((RecBytes = ns_zip.Read(RecData, 0, RecData.Length)) > 0)
                    {
                        Fs.Write(RecData, 0, RecBytes);
                        totalrecbytes += RecBytes;
                        Fs.Flush();
                    }
                    MessageBox.Show(totalrecbytes.ToString());
                    Fs.Flush();
                    Fs.Close();
                    
                    ns_zip.Close();
                }
            }
        }

        //------------ DESCONECTAR SERVER ------------------------------------------------------------------------------------
        private void btn_desconnect_serv_Click(object sender, EventArgs e)
        {
            lbx_Missatges.Items.Clear();
            cerrar();
            img_server.BackgroundImage = Image.FromFile(Application.StartupPath + @"\imatges\serv_off.png");
            Serv_On.Enabled = true;
            Serv_Off.Enabled = false;
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

            //if (this.client != null)
            //{
            //   client.Close();
            //}

            if (this.ns != null)
            {
                ns.Close();
            }

            if (this.ConexioPort != null)
            {
                ConexioPort.Abort();
            }

            if (this.ConexioPort1 != null)
            {
                ConexioPort1.Abort();
            }

            if (this.SendPort1 != null)
            {
                SendPort1.Abort();
            }
        }



        //----------------- FIN SERVIDOR ---------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------
    }
}
