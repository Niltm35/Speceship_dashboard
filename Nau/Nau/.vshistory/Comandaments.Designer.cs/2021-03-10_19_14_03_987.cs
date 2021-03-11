namespace Nau
{
    partial class Comandaments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comandaments));
            this.btn_comprovarXarxa = new System.Windows.Forms.Button();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.CatchKey = new System.Windows.Forms.Button();
            this.comboPlanet = new Controls03.SWComboFK();
            this.botoN_X1 = new Controls03.BOTON_X();
            this.ValidationCode = new System.Windows.Forms.TextBox();
            this.ValidationCode_Codificado = new System.Windows.Forms.TextBox();
            this.Codificar = new System.Windows.Forms.Button();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.txb_message = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Serv_Off = new System.Windows.Forms.Button();
            this.Serv_On = new System.Windows.Forms.Button();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.comboNau = new Controls03.SWComboFK();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.BackColor = System.Drawing.Color.Transparent;
            this.btn_comprovarXarxa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_comprovarXarxa.BackgroundImage")));
            this.btn_comprovarXarxa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_comprovarXarxa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comprovarXarxa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_comprovarXarxa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_comprovarXarxa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_comprovarXarxa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(355, 233);
            this.btn_comprovarXarxa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(130, 130);
            this.btn_comprovarXarxa.TabIndex = 0;
            this.btn_comprovarXarxa.UseVisualStyleBackColor = false;
            this.btn_comprovarXarxa.Click += new System.EventHandler(this.btn_comprovarXarxa_Click);
            // 
            // pnl_status
            // 
            this.pnl_status.BackColor = System.Drawing.Color.Red;
            this.pnl_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_status.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_status.Location = new System.Drawing.Point(373, 385);
            this.pnl_status.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(92, 54);
            this.pnl_status.TabIndex = 1;
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbx_console.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_console.ForeColor = System.Drawing.SystemColors.Window;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.ItemHeight = 18;
            this.lbx_console.Location = new System.Drawing.Point(509, 233);
            this.lbx_console.Margin = new System.Windows.Forms.Padding(5);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(144, 184);
            this.lbx_console.TabIndex = 1;
            // 
            // CatchKey
            // 
            this.CatchKey.BackColor = System.Drawing.Color.Transparent;
            this.CatchKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CatchKey.BackgroundImage")));
            this.CatchKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CatchKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatchKey.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CatchKey.FlatAppearance.BorderSize = 0;
            this.CatchKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.CatchKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.CatchKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatchKey.Location = new System.Drawing.Point(934, 233);
            this.CatchKey.Name = "CatchKey";
            this.CatchKey.Size = new System.Drawing.Size(130, 130);
            this.CatchKey.TabIndex = 2;
            this.CatchKey.UseVisualStyleBackColor = false;
            this.CatchKey.Click += new System.EventHandler(this.CatchKey_Click);
            // 
            // comboPlanet
            // 
            this.comboPlanet.BackColor = System.Drawing.Color.Black;
            this.comboPlanet.CampId = "idPlanet";
            this.comboPlanet.CampMostrar = "DescPlanet";
            this.comboPlanet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPlanet.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.comboPlanet.ForeColor = System.Drawing.Color.LightGray;
            this.comboPlanet.FormattingEnabled = true;
            this.comboPlanet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboPlanet.Location = new System.Drawing.Point(1103, 233);
            this.comboPlanet.Name = "comboPlanet";
            this.comboPlanet.nomTaula = "Planets";
            this.comboPlanet.Size = new System.Drawing.Size(171, 30);
            this.comboPlanet.TabIndex = 3;
            this.comboPlanet.SelectionChangeCommitted += new System.EventHandler(this.comboPlanets_SelectionChangeCommitted);
            // 
            // botoN_X1
            // 
            this.botoN_X1.BackColor = System.Drawing.Color.Transparent;
            this.botoN_X1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botoN_X1.BackgroundImage")));
            this.botoN_X1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoN_X1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoN_X1.FlatAppearance.BorderSize = 0;
            this.botoN_X1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_X1.Location = new System.Drawing.Point(1532, 95);
            this.botoN_X1.Name = "botoN_X1";
            this.botoN_X1.Size = new System.Drawing.Size(75, 29);
            this.botoN_X1.TabIndex = 4;
            this.botoN_X1.Text = " ";
            this.botoN_X1.UseVisualStyleBackColor = false;
            this.botoN_X1.Click += new System.EventHandler(this.botoN_X1_Click);
            // 
            // ValidationCode
            // 
            this.ValidationCode.BackColor = System.Drawing.Color.Black;
            this.ValidationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValidationCode.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationCode.ForeColor = System.Drawing.Color.LightGray;
            this.ValidationCode.Location = new System.Drawing.Point(1103, 278);
            this.ValidationCode.Multiline = true;
            this.ValidationCode.Name = "ValidationCode";
            this.ValidationCode.Size = new System.Drawing.Size(269, 36);
            this.ValidationCode.TabIndex = 5;
            this.ValidationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValidationCode_Codificado
            // 
            this.ValidationCode_Codificado.BackColor = System.Drawing.Color.Black;
            this.ValidationCode_Codificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValidationCode_Codificado.Font = new System.Drawing.Font("Consolas", 10.8F);
            this.ValidationCode_Codificado.ForeColor = System.Drawing.Color.LightGray;
            this.ValidationCode_Codificado.Location = new System.Drawing.Point(1103, 351);
            this.ValidationCode_Codificado.Multiline = true;
            this.ValidationCode_Codificado.Name = "ValidationCode_Codificado";
            this.ValidationCode_Codificado.ReadOnly = true;
            this.ValidationCode_Codificado.Size = new System.Drawing.Size(268, 159);
            this.ValidationCode_Codificado.TabIndex = 6;
            // 
            // Codificar
            // 
            this.Codificar.BackColor = System.Drawing.Color.Transparent;
            this.Codificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Codificar.BackgroundImage")));
            this.Codificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Codificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Codificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Codificar.FlatAppearance.BorderSize = 0;
            this.Codificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Codificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Codificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Codificar.Location = new System.Drawing.Point(934, 385);
            this.Codificar.Name = "Codificar";
            this.Codificar.Size = new System.Drawing.Size(130, 130);
            this.Codificar.TabIndex = 7;
            this.Codificar.UseVisualStyleBackColor = false;
            this.Codificar.Click += new System.EventHandler(this.Codificar_Click);
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.Enabled = false;
            this.btn_desconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desconnect.Location = new System.Drawing.Point(155, 98);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(127, 32);
            this.btn_desconnect.TabIndex = 8;
            this.btn_desconnect.Text = "Desconnect";
            this.btn_desconnect.UseVisualStyleBackColor = true;
            this.btn_desconnect.Click += new System.EventHandler(this.btn_desconnect_Click);
            // 
            // txb_message
            // 
            this.txb_message.Location = new System.Drawing.Point(13, 21);
            this.txb_message.Multiline = true;
            this.txb_message.Name = "txb_message";
            this.txb_message.Size = new System.Drawing.Size(275, 68);
            this.txb_message.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_desconnect);
            this.groupBox1.Controls.Add(this.txb_message);
            this.groupBox1.Controls.Add(this.btn_sendMessage);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(739, 656);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENT";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Enabled = false;
            this.btn_sendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendMessage.Location = new System.Drawing.Point(16, 98);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(127, 32);
            this.btn_sendMessage.TabIndex = 10;
            this.btn_sendMessage.Text = "Send Message";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Serv_Off);
            this.groupBox2.Controls.Add(this.Serv_On);
            this.groupBox2.Controls.Add(this.lbx_Missatges);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1070, 656);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 201);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // Serv_Off
            // 
            this.Serv_Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serv_Off.Location = new System.Drawing.Point(6, 61);
            this.Serv_Off.Name = "Serv_Off";
            this.Serv_Off.Size = new System.Drawing.Size(117, 31);
            this.Serv_Off.TabIndex = 2;
            this.Serv_Off.Text = "Descactivar";
            this.Serv_Off.UseVisualStyleBackColor = true;
            this.Serv_Off.Click += new System.EventHandler(this.btn_desconnect_serv_Click);
            // 
            // Serv_On
            // 
            this.Serv_On.BackColor = System.Drawing.Color.Transparent;
            this.Serv_On.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Serv_On.Location = new System.Drawing.Point(6, 24);
            this.Serv_On.Name = "Serv_On";
            this.Serv_On.Size = new System.Drawing.Size(117, 31);
            this.Serv_On.TabIndex = 1;
            this.Serv_On.Text = "Activar";
            this.Serv_On.UseVisualStyleBackColor = false;
            this.Serv_On.Click += new System.EventHandler(this.btn_connect_serv_Click);
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 16;
            this.lbx_Missatges.Location = new System.Drawing.Point(129, 14);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(165, 180);
            this.lbx_Missatges.TabIndex = 0;
            // 
            // comboNau
            // 
            this.comboNau.BackColor = System.Drawing.Color.Black;
            this.comboNau.CampId = "idSpaceShipType";
            this.comboNau.CampMostrar = "CodeSpaceShip";
            this.comboNau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboNau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboNau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.comboNau.ForeColor = System.Drawing.Color.LightGray;
            this.comboNau.FormattingEnabled = true;
            this.comboNau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboNau.Location = new System.Drawing.Point(1103, 197);
            this.comboNau.Name = "comboNau";
            this.comboNau.nomTaula = "SpaceShips";
            this.comboNau.Size = new System.Drawing.Size(171, 30);
            this.comboNau.TabIndex = 12;
            this.comboNau.SelectionChangeCommitted += new System.EventHandler(this.comboNau_SelectionChangeCommitted);
            // 
            // Comandaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.ControlBox = false;
            this.Controls.Add(this.comboNau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Codificar);
            this.Controls.Add(this.ValidationCode_Codificado);
            this.Controls.Add(this.ValidationCode);
            this.Controls.Add(this.botoN_X1);
            this.Controls.Add(this.comboPlanet);
            this.Controls.Add(this.CatchKey);
            this.Controls.Add(this.lbx_console);
            this.Controls.Add(this.pnl_status);
            this.Controls.Add(this.btn_comprovarXarxa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Comandaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Comandaments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comprovarXarxa;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Button CatchKey;
        private Controls03.SWComboFK comboPlanet;
        private Controls03.BOTON_X botoN_X1;
        private System.Windows.Forms.TextBox ValidationCode;
        private System.Windows.Forms.TextBox ValidationCode_Codificado;
        private System.Windows.Forms.Button Codificar;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.TextBox txb_message;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.Button Serv_On;
        private System.Windows.Forms.Button Serv_Off;
        private System.Windows.Forms.Label label1;
        private Controls03.SWComboFK comboNau;
    }
}