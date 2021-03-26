﻿using System;
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
            IP_Planet = TaulaPlanet().Tables[0].Rows[0][10].ToString();
            Port_Planet = TaulaPlanet().Tables[0].Rows[0][11].ToString();
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
        //-----------------CLIENT--------------------------------
        //Thread Fil_ping;
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
            string SELECT = "SELECT * FROM SpaceShips where idSpaceShipType = " + comboNau.SelectedValue;
            string TAULA = "SpaceShips";
            DataSet Data_Planet = bbdd.PortarPerConsulta(SELECT, TAULA);
            return Data_Planet;
        }
        private void comboPlanets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IP_Planet = TaulaPlanet().Tables[0].Rows[0][10].ToString();
            Port_Planet = TaulaPlanet().Tables[0].Rows[0][11].ToString();
            Port_Nau = TaulaNau().Tables[0].Rows[0][4].ToString();
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
                    //btn_sendMessage.Enabled = true;
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

                TcpClient client = new TcpClient(IP_Planet, Convert.ToInt32(Port_Nau));
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
            //lb_statusInfo.Text = "";
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
            label1.Text = "Conectado";
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
            label1.Text = "Servidor Desconectado";
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