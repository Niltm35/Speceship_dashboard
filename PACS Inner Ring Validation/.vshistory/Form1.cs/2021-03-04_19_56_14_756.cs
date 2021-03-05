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
            progressBar1.ForeColor = Color.Green;
            progressBar1.BackColor = Color.LightBlue;

            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
