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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comandaments));
            this.btn_comprovarXarxa = new System.Windows.Forms.Button();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.btn_CatchKey = new System.Windows.Forms.Button();
            this.btn_exit = new Controls03.BOTON_X();
            this.lbl_VK_codificado = new System.Windows.Forms.TextBox();
            this.btn_Codificar = new System.Windows.Forms.Button();
            this.btn_desconnectServer = new System.Windows.Forms.Button();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.btn_Serv_Off = new System.Windows.Forms.Button();
            this.btn_Serv_On = new System.Windows.Forms.Button();
            this.btn_peticion = new System.Windows.Forms.Button();
            this.comboPlanet = new System.Windows.Forms.ComboBox();
            this.comboNau = new System.Windows.Forms.ComboBox();
            this.comboDelivery = new System.Windows.Forms.ComboBox();
            this.Nau = new System.Windows.Forms.Label();
            this.planet = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.btn_Send_VK = new System.Windows.Forms.Button();
            this.lbl_VK = new System.Windows.Forms.Label();
            this.img_server = new System.Windows.Forms.PictureBox();
            this.lbl_ValidationCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.img_planet = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_DescodePACS = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_INFO = new System.Windows.Forms.Label();
            this.pnl_INFO = new System.Windows.Forms.Panel();
            this.gif_info = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gif_dec = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnl_plus_PACS = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bar_PACS1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.bar_PACS2 = new System.Windows.Forms.ProgressBar();
            this.bar_PACS3 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.img_server)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_planet)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_INFO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gif_info)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gif_dec)).BeginInit();
            this.pnl_plus_PACS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_comprovarXarxa.BackColor = System.Drawing.Color.Transparent;
            this.btn_comprovarXarxa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_comprovarXarxa.BackgroundImage")));
            this.btn_comprovarXarxa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_comprovarXarxa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_comprovarXarxa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_comprovarXarxa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_comprovarXarxa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_comprovarXarxa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(245, 588);
            this.btn_comprovarXarxa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(120, 121);
            this.btn_comprovarXarxa.TabIndex = 0;
            this.btn_comprovarXarxa.UseVisualStyleBackColor = false;
            this.btn_comprovarXarxa.Click += new System.EventHandler(this.btn_comprovarXarxa_Click);
            // 
            // pnl_status
            // 
            this.pnl_status.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnl_status.BackColor = System.Drawing.Color.Red;
            this.pnl_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_status.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_status.Location = new System.Drawing.Point(260, 747);
            this.pnl_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(92, 37);
            this.pnl_status.TabIndex = 1;
            // 
            // lbx_console
            // 
            this.lbx_console.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbx_console.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbx_console.Font = new System.Drawing.Font("Zelta-Six Demo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_console.ForeColor = System.Drawing.SystemColors.Window;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.ItemHeight = 16;
            this.lbx_console.Location = new System.Drawing.Point(403, 583);
            this.lbx_console.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(153, 212);
            this.lbx_console.TabIndex = 1;
            // 
            // btn_CatchKey
            // 
            this.btn_CatchKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CatchKey.BackColor = System.Drawing.Color.Transparent;
            this.btn_CatchKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_CatchKey.BackgroundImage")));
            this.btn_CatchKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_CatchKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CatchKey.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CatchKey.FlatAppearance.BorderSize = 0;
            this.btn_CatchKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_CatchKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_CatchKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CatchKey.Location = new System.Drawing.Point(1347, 615);
            this.btn_CatchKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CatchKey.Name = "btn_CatchKey";
            this.btn_CatchKey.Size = new System.Drawing.Size(120, 121);
            this.btn_CatchKey.TabIndex = 2;
            this.btn_CatchKey.UseVisualStyleBackColor = false;
            this.btn_CatchKey.Click += new System.EventHandler(this.CatchKey_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.Color.Black;
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Location = new System.Drawing.Point(1445, 30);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(91, 85);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = " ";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.botoN_X1_Click);
            // 
            // lbl_VK_codificado
            // 
            this.lbl_VK_codificado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VK_codificado.BackColor = System.Drawing.Color.Black;
            this.lbl_VK_codificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_VK_codificado.Font = new System.Drawing.Font("Zelta-Six Demo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VK_codificado.ForeColor = System.Drawing.Color.White;
            this.lbl_VK_codificado.Location = new System.Drawing.Point(1500, 750);
            this.lbl_VK_codificado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbl_VK_codificado.Multiline = true;
            this.lbl_VK_codificado.Name = "lbl_VK_codificado";
            this.lbl_VK_codificado.ReadOnly = true;
            this.lbl_VK_codificado.Size = new System.Drawing.Size(269, 118);
            this.lbl_VK_codificado.TabIndex = 6;
            // 
            // btn_Codificar
            // 
            this.btn_Codificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Codificar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Codificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Codificar.BackgroundImage")));
            this.btn_Codificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Codificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Codificar.Enabled = false;
            this.btn_Codificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Codificar.FlatAppearance.BorderSize = 0;
            this.btn_Codificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Codificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_Codificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Codificar.Location = new System.Drawing.Point(1347, 747);
            this.btn_Codificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Codificar.Name = "btn_Codificar";
            this.btn_Codificar.Size = new System.Drawing.Size(120, 121);
            this.btn_Codificar.TabIndex = 7;
            this.btn_Codificar.UseVisualStyleBackColor = false;
            this.btn_Codificar.Click += new System.EventHandler(this.Codificar_Click);
            // 
            // btn_desconnectServer
            // 
            this.btn_desconnectServer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_desconnectServer.BackColor = System.Drawing.Color.Transparent;
            this.btn_desconnectServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_desconnectServer.BackgroundImage")));
            this.btn_desconnectServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desconnectServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_desconnectServer.Enabled = false;
            this.btn_desconnectServer.FlatAppearance.BorderSize = 0;
            this.btn_desconnectServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_desconnectServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_desconnectServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desconnectServer.Font = new System.Drawing.Font("Zelta-Six Demo", 10.2F);
            this.btn_desconnectServer.ForeColor = System.Drawing.Color.White;
            this.btn_desconnectServer.Location = new System.Drawing.Point(260, 806);
            this.btn_desconnectServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconnectServer.Name = "btn_desconnectServer";
            this.btn_desconnectServer.Size = new System.Drawing.Size(187, 78);
            this.btn_desconnectServer.TabIndex = 8;
            this.btn_desconnectServer.Text = "Disconnect from Planet";
            this.btn_desconnectServer.UseVisualStyleBackColor = false;
            this.btn_desconnectServer.Click += new System.EventHandler(this.btn_desconnect_Click);
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbx_Missatges.BackColor = System.Drawing.Color.Silver;
            this.lbx_Missatges.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 22;
            this.lbx_Missatges.Location = new System.Drawing.Point(11, 44);
            this.lbx_Missatges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(551, 290);
            this.lbx_Missatges.TabIndex = 0;
            // 
            // btn_Serv_Off
            // 
            this.btn_Serv_Off.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Serv_Off.BackColor = System.Drawing.Color.Transparent;
            this.btn_Serv_Off.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Serv_Off.BackgroundImage")));
            this.btn_Serv_Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Serv_Off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Serv_Off.Enabled = false;
            this.btn_Serv_Off.FlatAppearance.BorderSize = 0;
            this.btn_Serv_Off.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Serv_Off.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Serv_Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Serv_Off.Font = new System.Drawing.Font("Zelta-Six Demo", 10.2F);
            this.btn_Serv_Off.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Serv_Off.Location = new System.Drawing.Point(267, 414);
            this.btn_Serv_Off.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Serv_Off.Name = "btn_Serv_Off";
            this.btn_Serv_Off.Size = new System.Drawing.Size(69, 54);
            this.btn_Serv_Off.TabIndex = 2;
            this.btn_Serv_Off.Text = "OFF";
            this.btn_Serv_Off.UseVisualStyleBackColor = false;
            this.btn_Serv_Off.Click += new System.EventHandler(this.btn_desconnect_serv_Click);
            // 
            // btn_Serv_On
            // 
            this.btn_Serv_On.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Serv_On.BackColor = System.Drawing.Color.Transparent;
            this.btn_Serv_On.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Serv_On.BackgroundImage")));
            this.btn_Serv_On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Serv_On.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Serv_On.Enabled = false;
            this.btn_Serv_On.FlatAppearance.BorderSize = 0;
            this.btn_Serv_On.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Serv_On.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Serv_On.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Serv_On.Font = new System.Drawing.Font("Zelta-Six Demo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Serv_On.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Serv_On.Location = new System.Drawing.Point(267, 334);
            this.btn_Serv_On.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Serv_On.Name = "btn_Serv_On";
            this.btn_Serv_On.Size = new System.Drawing.Size(69, 54);
            this.btn_Serv_On.TabIndex = 1;
            this.btn_Serv_On.Text = "ON";
            this.btn_Serv_On.UseVisualStyleBackColor = false;
            this.btn_Serv_On.Click += new System.EventHandler(this.btn_connect_serv_Click);
            // 
            // btn_peticion
            // 
            this.btn_peticion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_peticion.BackColor = System.Drawing.Color.Transparent;
            this.btn_peticion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_peticion.BackgroundImage")));
            this.btn_peticion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_peticion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_peticion.Enabled = false;
            this.btn_peticion.FlatAppearance.BorderSize = 0;
            this.btn_peticion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_peticion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_peticion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_peticion.Font = new System.Drawing.Font("Zelta-Six Demo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_peticion.ForeColor = System.Drawing.Color.White;
            this.btn_peticion.Location = new System.Drawing.Point(1509, 295);
            this.btn_peticion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_peticion.Name = "btn_peticion";
            this.btn_peticion.Size = new System.Drawing.Size(187, 78);
            this.btn_peticion.TabIndex = 13;
            this.btn_peticion.Text = "Entry\r\nRequirement";
            this.btn_peticion.UseVisualStyleBackColor = false;
            this.btn_peticion.Click += new System.EventHandler(this.btn_peticion_Click);
            // 
            // comboPlanet
            // 
            this.comboPlanet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboPlanet.BackColor = System.Drawing.Color.Black;
            this.comboPlanet.DisplayMember = "DescPlanet";
            this.comboPlanet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlanet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPlanet.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlanet.ForeColor = System.Drawing.Color.LightGray;
            this.comboPlanet.FormattingEnabled = true;
            this.comboPlanet.Location = new System.Drawing.Point(931, 377);
            this.comboPlanet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboPlanet.Name = "comboPlanet";
            this.comboPlanet.Size = new System.Drawing.Size(220, 35);
            this.comboPlanet.TabIndex = 15;
            this.comboPlanet.ValueMember = "idPlanet";
            this.comboPlanet.SelectedIndexChanged += new System.EventHandler(this.comboPlanet_SelectedIndexChanged);
            // 
            // comboNau
            // 
            this.comboNau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboNau.BackColor = System.Drawing.Color.Black;
            this.comboNau.DisplayMember = "codeSpaceShip";
            this.comboNau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboNau.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboNau.ForeColor = System.Drawing.Color.White;
            this.comboNau.FormattingEnabled = true;
            this.comboNau.Location = new System.Drawing.Point(673, 377);
            this.comboNau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboNau.Name = "comboNau";
            this.comboNau.Size = new System.Drawing.Size(220, 35);
            this.comboNau.TabIndex = 16;
            this.comboNau.ValueMember = "idSpaceShip";
            this.comboNau.SelectedIndexChanged += new System.EventHandler(this.comboNau_SelectedIndexChanged);
            // 
            // comboDelivery
            // 
            this.comboDelivery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboDelivery.BackColor = System.Drawing.Color.Black;
            this.comboDelivery.DisplayMember = "CodeDelivery";
            this.comboDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboDelivery.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDelivery.ForeColor = System.Drawing.Color.LightGray;
            this.comboDelivery.FormattingEnabled = true;
            this.comboDelivery.Location = new System.Drawing.Point(1184, 377);
            this.comboDelivery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboDelivery.Name = "comboDelivery";
            this.comboDelivery.Size = new System.Drawing.Size(220, 35);
            this.comboDelivery.TabIndex = 17;
            this.comboDelivery.ValueMember = "idDeliveryData";
            // 
            // Nau
            // 
            this.Nau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Nau.BackColor = System.Drawing.Color.Black;
            this.Nau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nau.Font = new System.Drawing.Font("Zelta-Six Demo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nau.ForeColor = System.Drawing.Color.LightGray;
            this.Nau.Location = new System.Drawing.Point(673, 331);
            this.Nau.Name = "Nau";
            this.Nau.Size = new System.Drawing.Size(221, 40);
            this.Nau.TabIndex = 18;
            this.Nau.Text = "SpaceShips";
            this.Nau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planet
            // 
            this.planet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.planet.BackColor = System.Drawing.Color.Black;
            this.planet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planet.Font = new System.Drawing.Font("Zelta-Six Demo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planet.ForeColor = System.Drawing.Color.LightGray;
            this.planet.Location = new System.Drawing.Point(931, 331);
            this.planet.Name = "planet";
            this.planet.Size = new System.Drawing.Size(221, 40);
            this.planet.TabIndex = 19;
            this.planet.Text = "Planet";
            this.planet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delivery
            // 
            this.delivery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.delivery.BackColor = System.Drawing.Color.Black;
            this.delivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delivery.Font = new System.Drawing.Font("Zelta-Six Demo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.ForeColor = System.Drawing.Color.LightGray;
            this.delivery.Location = new System.Drawing.Point(1184, 331);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(221, 40);
            this.delivery.TabIndex = 20;
            this.delivery.Text = "Delivery";
            this.delivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Send_VK
            // 
            this.btn_Send_VK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send_VK.BackColor = System.Drawing.Color.Transparent;
            this.btn_Send_VK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Send_VK.BackgroundImage")));
            this.btn_Send_VK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send_VK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send_VK.Enabled = false;
            this.btn_Send_VK.FlatAppearance.BorderSize = 0;
            this.btn_Send_VK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Send_VK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Send_VK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send_VK.Font = new System.Drawing.Font("Zelta-Six Demo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send_VK.ForeColor = System.Drawing.Color.White;
            this.btn_Send_VK.Location = new System.Drawing.Point(1509, 396);
            this.btn_Send_VK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send_VK.Name = "btn_Send_VK";
            this.btn_Send_VK.Size = new System.Drawing.Size(187, 78);
            this.btn_Send_VK.TabIndex = 22;
            this.btn_Send_VK.Text = "Send Validation Key";
            this.btn_Send_VK.UseVisualStyleBackColor = false;
            this.btn_Send_VK.Click += new System.EventHandler(this.Send_PublicKey_Click);
            // 
            // lbl_VK
            // 
            this.lbl_VK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_VK.BackColor = System.Drawing.Color.Black;
            this.lbl_VK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_VK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VK.ForeColor = System.Drawing.Color.White;
            this.lbl_VK.Location = new System.Drawing.Point(1499, 650);
            this.lbl_VK.Name = "lbl_VK";
            this.lbl_VK.Size = new System.Drawing.Size(269, 48);
            this.lbl_VK.TabIndex = 25;
            this.lbl_VK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_server
            // 
            this.img_server.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.img_server.BackColor = System.Drawing.Color.Black;
            this.img_server.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_server.Location = new System.Drawing.Point(403, 331);
            this.img_server.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_server.Name = "img_server";
            this.img_server.Size = new System.Drawing.Size(145, 140);
            this.img_server.TabIndex = 24;
            this.img_server.TabStop = false;
            // 
            // lbl_ValidationCode
            // 
            this.lbl_ValidationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ValidationCode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ValidationCode.Font = new System.Drawing.Font("Consolas", 10F);
            this.lbl_ValidationCode.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_ValidationCode.Location = new System.Drawing.Point(1499, 615);
            this.lbl_ValidationCode.Name = "lbl_ValidationCode";
            this.lbl_ValidationCode.Size = new System.Drawing.Size(269, 25);
            this.lbl_ValidationCode.TabIndex = 28;
            this.lbl_ValidationCode.Text = " Validation Code:";
            this.lbl_ValidationCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Messages:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbx_Missatges);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(756, 528);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(571, 367);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // img_planet
            // 
            this.img_planet.BackColor = System.Drawing.Color.Transparent;
            this.img_planet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_planet.Location = new System.Drawing.Point(67, 14);
            this.img_planet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_planet.Name = "img_planet";
            this.img_planet.Size = new System.Drawing.Size(261, 159);
            this.img_planet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_planet.TabIndex = 35;
            this.img_planet.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.img_planet);
            this.panel1.Location = new System.Drawing.Point(163, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 186);
            this.panel1.TabIndex = 36;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.Black;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(1445, 121);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(91, 85);
            this.btn_back.TabIndex = 37;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_DescodePACS
            // 
            this.btn_DescodePACS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DescodePACS.BackColor = System.Drawing.Color.Transparent;
            this.btn_DescodePACS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DescodePACS.BackgroundImage")));
            this.btn_DescodePACS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DescodePACS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DescodePACS.FlatAppearance.BorderSize = 0;
            this.btn_DescodePACS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_DescodePACS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_DescodePACS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DescodePACS.Font = new System.Drawing.Font("Zelta-Six Demo", 10.2F);
            this.btn_DescodePACS.ForeColor = System.Drawing.Color.White;
            this.btn_DescodePACS.Location = new System.Drawing.Point(1509, 498);
            this.btn_DescodePACS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DescodePACS.Name = "btn_DescodePACS";
            this.btn_DescodePACS.Size = new System.Drawing.Size(187, 78);
            this.btn_DescodePACS.TabIndex = 38;
            this.btn_DescodePACS.Text = "Decode and send PACS";
            this.btn_DescodePACS.UseVisualStyleBackColor = false;
            this.btn_DescodePACS.Click += new System.EventHandler(this.btn_des_zip_Click);
            // 
            // lbl_INFO
            // 
            this.lbl_INFO.BackColor = System.Drawing.Color.Transparent;
            this.lbl_INFO.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_INFO.ForeColor = System.Drawing.Color.White;
            this.lbl_INFO.Location = new System.Drawing.Point(239, 58);
            this.lbl_INFO.Name = "lbl_INFO";
            this.lbl_INFO.Size = new System.Drawing.Size(247, 65);
            this.lbl_INFO.TabIndex = 39;
            this.lbl_INFO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_INFO
            // 
            this.pnl_INFO.BackColor = System.Drawing.Color.Black;
            this.pnl_INFO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_INFO.BackgroundImage")));
            this.pnl_INFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_INFO.Controls.Add(this.pnl_plus_PACS);
            this.pnl_INFO.Controls.Add(this.button1);
            this.pnl_INFO.Controls.Add(this.lbl_INFO);
            this.pnl_INFO.Controls.Add(this.gif_info);
            this.pnl_INFO.Location = new System.Drawing.Point(571, 26);
            this.pnl_INFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_INFO.Name = "pnl_INFO";
            this.pnl_INFO.Size = new System.Drawing.Size(549, 186);
            this.pnl_INFO.TabIndex = 41;
            // 
            // gif_info
            // 
            this.gif_info.Enabled = true;
            this.gif_info.Location = new System.Drawing.Point(49, 18);
            this.gif_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gif_info.Name = "gif_info";
            this.gif_info.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gif_info.OcxState")));
            this.gif_info.Size = new System.Drawing.Size(125, 115);
            this.gif_info.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnl_INFO);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(137, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1699, 244);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.gif_dec);
            this.panel3.Location = new System.Drawing.Point(1127, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 186);
            this.panel3.TabIndex = 38;
            // 
            // gif_dec
            // 
            this.gif_dec.Enabled = true;
            this.gif_dec.Location = new System.Drawing.Point(56, 12);
            this.gif_dec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gif_dec.Name = "gif_dec";
            this.gif_dec.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("gif_dec.OcxState")));
            this.gif_dec.Size = new System.Drawing.Size(194, 127);
            this.gif_dec.TabIndex = 41;
            this.gif_dec.Enter += new System.EventHandler(this.gif_dec_Enter);
            // 
            // pnl_plus_PACS
            // 
            this.pnl_plus_PACS.BackColor = System.Drawing.Color.Black;
            this.pnl_plus_PACS.Controls.Add(this.bar_PACS3);
            this.pnl_plus_PACS.Controls.Add(this.bar_PACS2);
            this.pnl_plus_PACS.Controls.Add(this.label4);
            this.pnl_plus_PACS.Controls.Add(this.label3);
            this.pnl_plus_PACS.Controls.Add(this.label1);
            this.pnl_plus_PACS.Controls.Add(this.bar_PACS1);
            this.pnl_plus_PACS.Location = new System.Drawing.Point(192, 29);
            this.pnl_plus_PACS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_plus_PACS.Name = "pnl_plus_PACS";
            this.pnl_plus_PACS.Size = new System.Drawing.Size(338, 94);
            this.pnl_plus_PACS.TabIndex = 46;
            this.pnl_plus_PACS.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_plus_PACS_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "PACS 3";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "PACS 2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "PACS 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bar_PACS1
            // 
            this.bar_PACS1.ForeColor = System.Drawing.Color.Green;
            this.bar_PACS1.Location = new System.Drawing.Point(107, 10);
            this.bar_PACS1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bar_PACS1.Name = "bar_PACS1";
            this.bar_PACS1.Size = new System.Drawing.Size(191, 20);
            this.bar_PACS1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bar_PACS2
            // 
            this.bar_PACS2.ForeColor = System.Drawing.Color.Green;
            this.bar_PACS2.Location = new System.Drawing.Point(107, 38);
            this.bar_PACS2.Margin = new System.Windows.Forms.Padding(4);
            this.bar_PACS2.Name = "bar_PACS2";
            this.bar_PACS2.Size = new System.Drawing.Size(191, 20);
            this.bar_PACS2.TabIndex = 6;
            // 
            // bar_PACS3
            // 
            this.bar_PACS3.ForeColor = System.Drawing.Color.Green;
            this.bar_PACS3.Location = new System.Drawing.Point(107, 66);
            this.bar_PACS3.Margin = new System.Windows.Forms.Padding(4);
            this.bar_PACS3.Name = "bar_PACS3";
            this.bar_PACS3.Size = new System.Drawing.Size(191, 20);
            this.bar_PACS3.TabIndex = 7;
            // 
            // Comandaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 994);
            this.ControlBox = false;
            this.Controls.Add(this.btn_DescodePACS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_ValidationCode);
            this.Controls.Add(this.btn_desconnectServer);
            this.Controls.Add(this.img_server);
            this.Controls.Add(this.lbx_console);
            this.Controls.Add(this.lbl_VK);
            this.Controls.Add(this.btn_comprovarXarxa);
            this.Controls.Add(this.btn_Send_VK);
            this.Controls.Add(this.pnl_status);
            this.Controls.Add(this.btn_Serv_Off);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.btn_Serv_On);
            this.Controls.Add(this.planet);
            this.Controls.Add(this.Nau);
            this.Controls.Add(this.comboDelivery);
            this.Controls.Add(this.comboNau);
            this.Controls.Add(this.comboPlanet);
            this.Controls.Add(this.btn_peticion);
            this.Controls.Add(this.btn_Codificar);
            this.Controls.Add(this.lbl_VK_codificado);
            this.Controls.Add(this.btn_CatchKey);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Comandaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Comandaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_server)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_planet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_INFO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gif_info)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gif_dec)).EndInit();
            this.pnl_plus_PACS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comprovarXarxa;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Button btn_CatchKey;
        private Controls03.BOTON_X btn_exit;
        private System.Windows.Forms.TextBox lbl_VK_codificado;
        private System.Windows.Forms.Button btn_Codificar;
        private System.Windows.Forms.Button btn_desconnectServer;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.Button btn_Serv_On;
        private System.Windows.Forms.Button btn_Serv_Off;
        private System.Windows.Forms.Button btn_peticion;
        private System.Windows.Forms.ComboBox comboPlanet;
        private System.Windows.Forms.ComboBox comboNau;
        private System.Windows.Forms.ComboBox comboDelivery;
        private System.Windows.Forms.Label Nau;
        private System.Windows.Forms.Label planet;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Button btn_Send_VK;
        private System.Windows.Forms.Label lbl_VK;
        private System.Windows.Forms.PictureBox img_server;
        private System.Windows.Forms.Label lbl_ValidationCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox img_planet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_DescodePACS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_INFO;
        private System.Windows.Forms.Panel pnl_INFO;
        private AxWMPLib.AxWindowsMediaPlayer gif_info;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer gif_dec;
        private System.Windows.Forms.Panel pnl_plus_PACS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar bar_PACS1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar bar_PACS3;
        private System.Windows.Forms.ProgressBar bar_PACS2;
    }
}