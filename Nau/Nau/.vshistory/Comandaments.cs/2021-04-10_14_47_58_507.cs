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
using System.Collections;

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
            btn_Serv_On.Enabled = true;
            btn_Serv_Off.Enabled = false;

            btn_Codificar.Enabled = false;
            //btn_sendMessage.Enabled = false;
            btn_peticion.Enabled = false;
            btn_Send_VK.Enabled = false;
            btn_DescodePACS.Enabled = true;
            btn_desconnectServer.Enabled = false;
            gif_info.uiMode = "none";
            gif_info.settings.setMode("loop", true);
            gif_dec.uiMode = "none";
            gif_dec.settings.setMode("loop", true);
            gif_dec.URL = Application.StartupPath + @"\imatges\dec1.gif";

            pnl_plus_PACS.Hide();
            button1.Hide();

        }

        private void botoN_X1_Click(object sender, EventArgs e)
        {
            cerrar();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form frm2 = this.FindForm();
            frm2.Close();

            //bool exist = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Nau")
                {
                    //exist = true;
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
            lbl_VK.Text = bbdd.PortarPerTaula(taula,query).Rows[0][0].ToString();

            string query_key = "SELECT XMLKey FROM PlanetKeys where idPlanet = " + comboPlanet.SelectedValue;
            string taula_key = "PlanetKeys";
            xmlKey = bbdd.PortarPerTaula(taula_key, query_key).Rows[0][0].ToString();

            btn_Codificar.Enabled = true;
        }

        string VK_codificada;
        string xmlKey;
        byte[] encryptedData;

        private void selec_VK()
        {
            string query = "SELECT ValidationCode FROM InnerEncryption where idPlanet = " + comboPlanet.SelectedValue;
            string taula = "InnerEncryption";
            lbl_VK.Text = bbdd.PortarPerTaula(taula, query).Rows[0][0].ToString();

            string query_key = "SELECT XMLKey FROM PlanetKeys where idPlanet = " + comboPlanet.SelectedValue;
            string taula_key = "PlanetKeys";
            xmlKey = bbdd.PortarPerTaula(taula_key, query_key).Rows[0][0].ToString();

            btn_Codificar.Enabled = true;
        }
        private void codificar_VK()
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(lbl_VK.Text);

            RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

            rsaEnc.FromXmlString(xmlKey);
            encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);

            VK_codificada = ByteConverter.GetString(encryptedData);

            lbl_VK_codificado.Text = VK_codificada;
            btn_Send_VK.Enabled = true;
        }

        private void Codificar_Click(object sender, EventArgs e)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(lbl_VK.Text);

            RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();

            rsaEnc.FromXmlString(xmlKey);
            encryptedData = rsaEnc.Encrypt(dataToEncrypt, false);

            VK_codificada = ByteConverter.GetString(encryptedData);

            lbl_VK_codificado.Text = VK_codificada;
            btn_Send_VK.Enabled = true;
        }

        private void btn_peticion_Click(object sender, EventArgs e)
        {
            string type = "ER";
            string code_Nau = TaulaNau().Tables[0].Rows[0][2].ToString();
            string code_Delivery = TaulaDelivery().Tables[0].Rows[0][1].ToString();
            string ER_ms = type + code_Nau + code_Delivery;
            lbl_INFO.Text = "Waiting answer";
            gif_info.URL = Application.StartupPath + @"\imatges\waiting.png";
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

        public DataTable TaulaDescodificar()
        {
            string SELECT = "SELECT Word, Numbers FROM InnerEncryptionData where IdInnerEncryption = '" + comboPlanet.SelectedValue + "'";
            string TAULA = "InnerEncryptionData";
            DataTable Data_Delivery = bbdd.PortarPerTaula(TAULA, SELECT);
            return Data_Delivery;
        }



        Dictionary<String, String> Diccionario_Code = new Dictionary<string, string>();

        private void LibreriaCode()
        {
            //____________
            DataTable hola = TaulaDescodificar();
            for (int i = 0; i < hola.Rows.Count; i++)
            {
                string valor = hola.Rows[i]["Numbers"].ToString();
                string lletra = hola.Rows[i]["Word"].ToString();
                Diccionario_Code.Add(valor, lletra);

            }
        }

        //------------------------------
        private void ping()
        {
            btn_comprovarXarxa.Enabled = false;
            btn_desconnectServer.Enabled = false;
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
                    btn_desconnectServer.Enabled = false;
                }
                else
                {
                    pnl_status.BackColor = Color.Green;
                    btn_comprovarXarxa.Enabled = true;
                    btn_desconnectServer.Enabled = true;
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
            //btn_sendMessage.Enabled = true;
            btn_desconnectServer.Enabled = true;
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
                lbl_INFO.Text = "Server inaccessible";
                gif_info.URL = Application.StartupPath + @"\imatges\err_serv.png";
                //lbl_INFO.BackColor = Color.Yellow;
            }
        }

        private void SendVK(byte[] dades)
        {
            try
            {
                TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port1_Planet));
                NetworkStream ns = client.GetStream();
                ns.Write(dades, 0, dades.Length);
                //sendPort1();
                lbl_INFO.Text = "Message sent";
                gif_info.URL = PathImgs + @"\ing.png";

            }
            catch
            {
                lbl_INFO.Text = "Server inaccessible (VK)";
                gif_info.URL = Application.StartupPath + @"\imatges\err_serv.png";
                
            }
            
        }

        Thread SendPort1;
        

        //private void btn_sendMessage_Click(object sender, EventArgs e)
        //{
        //    sendPort();
        //}

        //public void sendPort()
        //{
        //    TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port_Planet));
        //    if (txb_message.Text == "")
        //    {
        //        /////////////////////////////////////////////////////////////////////////////////////////////////
        //        info_warring = "El missatge no por estar buit";
        //        Warning _warning = new Warning();
        //        _warning.INFO = info_warring;
        //        _warning.Show();
        //    }
        //    else
        //    {
        //        Byte[] dades = Encoding.ASCII.GetBytes(txb_message.Text);
        //        NetworkStream ns = client.GetStream();
        //        ns.Write(dades, 0, dades.Length);
        //        lbx_Missatges.Items.Add("YOU: " + txb_message.Text);
        //    }
        //}

        public void sendPort1()
        {
            Descodificar.Join();
            TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port1_Planet));
            NetworkStream ns_zip = client.GetStream();

            string zipFile = Application.StartupPath + @"\Fitxers\PACS_Desc.txt";
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
        string PathImgs = Application.StartupPath + @"\imatges";
        public void message_planet(string ms)
        {
            string request = ms.Substring(0, 2);
            string answer = ms.Substring(14, 2);
            string Message, Icon = "";

            if (request == "VR")
            {
                if (answer == "VP")
                {
                    Message = "Validation ln Progress";
                    Icon = PathImgs + @"\load.gif";
                    
                }
                else if (answer == "AD")
                {
                    Message = "Access Denied";
                    Icon = PathImgs + @"\error1.png";

                }
                else if (answer == "AG")
                {
                    
                    Message = "Access Granted";
                    Icon = PathImgs + @"\descarga1.png";

                }
                else
                {
                    Message = "Error message: " + ms;
                    Warning _warning = new Warning();
                    _warning.INFO = Message;
                    _warning.Show();
                }
            }
            else
            {
                Message = "Error message: " + ms;
                gif_info.URL = PathImgs + @"\warring.png";
            }

            lbl_INFO.Text = Message;
            gif_info.URL = Icon;
            //gif_info.settings.setMode("loop", true);
        }
        Thread Hilo_VK;
        private void Send_PublicKey_Click(object sender, EventArgs e)
        {
            //selec_VK();
            //codificar_VK();
            //Thread.Sleep(1000);
            //SendVK(encryptedData);

            SendMessage("VK");
            Thread.Sleep(1000);
            Hilo_VK = new Thread(SVK);
            Hilo_VK.Start();
        }

        private void SVK()
        {
            lbl_INFO.Text = "Sending message";
            gif_info.URL = PathImgs + @"\sending.gif";
            Thread.Sleep(1000);
            SendVK(encryptedData);
            Hilo_VK.Abort();
            
        }

        Thread Descodificar;
        private void btn_des_zip_Click(object sender, EventArgs e)
        {

            lbl_INFO.Text = "Decoding PACS";
            gif_info.URL = PathImgs + @"\load.gif";
            Descodificar = new Thread(descodificacion_zip);
            Descodificar.Start();
            
            //SendPort1 = new Thread(sendPort1);
            //SendPort1.Start();
        }

        private void descodificacion_zip()
        {
            LibreriaCode();
            //pnl_plus_PACS.Show();
            button1.Show();

            string extractPath = Application.StartupPath + @"\Fitxers\PACS";

            if (Directory.Exists(extractPath))
            {
                Directory.Delete(extractPath, true);
            }
            ZipFile.ExtractToDirectory(zipPath, extractPath);

            for(int i=1; i<4; i++)
            {
                string text = File.ReadAllText(extractPath + @"\PACS" + i + ".txt");
                string path = Application.StartupPath + @"\Fitxers\PACS" + i + "_desc.txt";

                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs);
                int leido = 0;

                bar_PACS1.Maximum = text.Length - 3;
                bar_PACS2.Maximum = text.Length - 3;
                bar_PACS3.Maximum = text.Length - 3;
                bar_PACS1.Step = 3;
                bar_PACS2.Step = 3;
                bar_PACS3.Step = 3;

                while (leido < text.Length - 3)
                {
                    string codi = text.Substring(leido, 3);

                    if (i == 1)
                    {
                        bar_PACS1.PerformStep();
                        leido = bar_PACS1.Value;
                    }
                    else if (i == 2)
                    {
                        bar_PACS2.PerformStep();
                        leido = bar_PACS1.Value;
                    }
                    else if (i == 3)
                    {
                        bar_PACS3.PerformStep();
                        leido = bar_PACS1.Value;
                    }

                    if (Diccionario_Code.TryGetValue(codi, out string value))
                    {
                        string letra = value;
                        writer.Write(letra);
                        leido = leido + 3;

                        if (i == 1)
                        {
                            bar_PACS1.PerformStep();
                        }
                        else if (i == 2)
                        {
                            bar_PACS2.PerformStep();
                        }
                        else if (i == 3)
                        {
                            bar_PACS3.PerformStep();
                        }
                    }
                }
                writer.Close();
                MessageBox.Show("PACS"+i+" descodificado");
            }

            
            string txtHash, txtPACS = "";

            for (int i = 1; i < 4; i++)
            {
                string text = File.ReadAllText(Application.StartupPath + @"\Fitxers\PACS" + i + "_desc.txt");
                string PACS1 = "", PACS2 = "", PACS3 = "";

                if (i == 1)
                {
                    PACS1 = text;
                }
                else if (i == 2)
                {
                    PACS2 = text;
                }
                else if (i == 3)
                {
                    PACS3 = text;
                }

                string PACS_desc = Application.StartupPath + @"\Fitxers\PACS_Desc.txt";
                FileStream fs = new FileStream(PACS_desc, FileMode.Create, FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);
                txtPACS = PACS1 + PACS2 + PACS3;
                wr.Write(txtPACS);
                wr.Close();
            }
            txtHash = bbdd.GetMD5Hash(txtPACS);
            //SendMessage(txtHash);
            MessageBox.Show("Fitxero descodificado y enviado");
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
            //txb_message.Text = "";
            //btn_sendMessage.Enabled = false;
            btn_desconnectServer.Enabled = false;
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
                btn_Serv_On.Enabled = false;
                btn_Serv_Off.Enabled = true;
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
                lbl_INFO.Text = Message;
                gif_info.URL = Application.StartupPath + @"\imatges\warring.png";
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
                    btn_DescodePACS.Enabled = true;
                    lbl_INFO.Text = "Downloaded PACS files";
                    gif_info.URL = PathImgs + @"\fichero.png";
                    //////////////////////////////////////////
                }
            }
        }

        //------------ DESCONECTAR SERVER ------------------------------------------------------------------------------------
        private void btn_desconnect_serv_Click(object sender, EventArgs e)
        {
            lbx_Missatges.Items.Clear();
            cerrar();
            img_server.BackgroundImage = Image.FromFile(Application.StartupPath + @"\imatges\serv_off.png");
            btn_Serv_On.Enabled = true;
            btn_Serv_Off.Enabled = false;
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

        private void gif_dec_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_plus_PACS.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnl_plus_PACS_Paint(object sender, PaintEventArgs e)
        {

        }

        //----------------- FIN SERVIDOR ---------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------
    }
}