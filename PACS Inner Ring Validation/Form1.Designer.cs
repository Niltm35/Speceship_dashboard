namespace PACS_Inner_Ring_Validation
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ValidationGenerate_button = new System.Windows.Forms.Button();
            this.comboPlanets = new Controls03.SWComboFK();
            this.KeyGenerator_button = new System.Windows.Forms.Button();
            this.Desencriptar_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.botoN_X1 = new Controls03.BOTON_X();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.botoN_MIN1 = new Controls03.BOTON_MIN();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.desc = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_message = new System.Windows.Forms.TextBox();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.lb_statusInfo = new System.Windows.Forms.Label();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.btn_comprovarXarxa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValidationGenerate_button
            // 
            this.ValidationGenerate_button.BackColor = System.Drawing.Color.Transparent;
            this.ValidationGenerate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ValidationGenerate_button.FlatAppearance.BorderSize = 0;
            this.ValidationGenerate_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ValidationGenerate_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ValidationGenerate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValidationGenerate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationGenerate_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.ValidationGenerate_button.Location = new System.Drawing.Point(43, 438);
            this.ValidationGenerate_button.Name = "ValidationGenerate_button";
            this.ValidationGenerate_button.Size = new System.Drawing.Size(160, 38);
            this.ValidationGenerate_button.TabIndex = 1;
            this.ValidationGenerate_button.Text = "Validation Code";
            this.ValidationGenerate_button.UseVisualStyleBackColor = false;
            this.ValidationGenerate_button.Click += new System.EventHandler(this.ValidationGenerate_button_Click);
            // 
            // comboPlanets
            // 
            this.comboPlanets.BackColor = System.Drawing.SystemColors.ControlText;
            this.comboPlanets.CampId = "idPlanet";
            this.comboPlanets.CampMostrar = "DescPlanet";
            this.comboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlanets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPlanets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlanets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.comboPlanets.FormattingEnabled = true;
            this.comboPlanets.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboPlanets.Location = new System.Drawing.Point(1173, 135);
            this.comboPlanets.Name = "comboPlanets";
            this.comboPlanets.nomTaula = "Planets";
            this.comboPlanets.Size = new System.Drawing.Size(156, 26);
            this.comboPlanets.TabIndex = 5;
            this.comboPlanets.SelectionChangeCommitted += new System.EventHandler(this.comboPlanets_SelectedIndexChanged);
            // 
            // KeyGenerator_button
            // 
            this.KeyGenerator_button.BackColor = System.Drawing.Color.Transparent;
            this.KeyGenerator_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyGenerator_button.FlatAppearance.BorderSize = 0;
            this.KeyGenerator_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.KeyGenerator_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.KeyGenerator_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyGenerator_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyGenerator_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.KeyGenerator_button.Location = new System.Drawing.Point(1178, 222);
            this.KeyGenerator_button.Name = "KeyGenerator_button";
            this.KeyGenerator_button.Size = new System.Drawing.Size(144, 80);
            this.KeyGenerator_button.TabIndex = 6;
            this.KeyGenerator_button.Text = "PublicKey";
            this.KeyGenerator_button.UseVisualStyleBackColor = false;
            this.KeyGenerator_button.Click += new System.EventHandler(this.KeyGenerator_button_Click);
            // 
            // Desencriptar_button
            // 
            this.Desencriptar_button.BackColor = System.Drawing.Color.Transparent;
            this.Desencriptar_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Desencriptar_button.FlatAppearance.BorderSize = 0;
            this.Desencriptar_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Desencriptar_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Desencriptar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desencriptar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desencriptar_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.Desencriptar_button.Location = new System.Drawing.Point(1178, 365);
            this.Desencriptar_button.Name = "Desencriptar_button";
            this.Desencriptar_button.Size = new System.Drawing.Size(144, 80);
            this.Desencriptar_button.TabIndex = 7;
            this.Desencriptar_button.Text = "Decript";
            this.Desencriptar_button.UseVisualStyleBackColor = false;
            this.Desencriptar_button.Click += new System.EventHandler(this.Desencriptar_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.textBox1.Location = new System.Drawing.Point(29, 358);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 43);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.textBox2.Location = new System.Drawing.Point(293, 234);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 207);
            this.textBox2.TabIndex = 9;
            // 
            // botoN_X1
            // 
            this.botoN_X1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botoN_X1.BackColor = System.Drawing.Color.Black;
            this.botoN_X1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botoN_X1.BackgroundImage")));
            this.botoN_X1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoN_X1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoN_X1.FlatAppearance.BorderSize = 0;
            this.botoN_X1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botoN_X1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_X1.Location = new System.Drawing.Point(1331, 7);
            this.botoN_X1.Name = "botoN_X1";
            this.botoN_X1.Size = new System.Drawing.Size(27, 27);
            this.botoN_X1.TabIndex = 10;
            this.botoN_X1.Text = " ";
            this.botoN_X1.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.progressBar1.Location = new System.Drawing.Point(949, 554);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(109, 14);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            // 
            // botoN_MIN1
            // 
            this.botoN_MIN1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botoN_MIN1.BackColor = System.Drawing.Color.Black;
            this.botoN_MIN1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botoN_MIN1.BackgroundImage")));
            this.botoN_MIN1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoN_MIN1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoN_MIN1.FlatAppearance.BorderSize = 0;
            this.botoN_MIN1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botoN_MIN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_MIN1.Location = new System.Drawing.Point(1294, 7);
            this.botoN_MIN1.Name = "botoN_MIN1";
            this.botoN_MIN1.Size = new System.Drawing.Size(27, 27);
            this.botoN_MIN1.TabIndex = 12;
            this.botoN_MIN1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(46, 101);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(149, 128);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.label1.Location = new System.Drawing.Point(28, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 62);
            this.label1.TabIndex = 14;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_Missatges);
            this.groupBox1.Controls.Add(this.desc);
            this.groupBox1.Controls.Add(this.conectar);
            this.groupBox1.Location = new System.Drawing.Point(553, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 181);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.Location = new System.Drawing.Point(6, 19);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(216, 95);
            this.lbx_Missatges.TabIndex = 2;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(87, 141);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(75, 23);
            this.desc.TabIndex = 1;
            this.desc.Text = "desc";
            this.desc.UseVisualStyleBackColor = true;
            this.desc.Click += new System.EventHandler(this.btn_desconnect_serv_Click);
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(6, 141);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(75, 23);
            this.conectar.TabIndex = 0;
            this.conectar.Text = "co";
            this.conectar.UseVisualStyleBackColor = true;
            this.conectar.Click += new System.EventHandler(this.btn_connect_serv_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_message);
            this.groupBox2.Controls.Add(this.pnl_status);
            this.groupBox2.Controls.Add(this.lbx_console);
            this.groupBox2.Controls.Add(this.lb_statusInfo);
            this.groupBox2.Controls.Add(this.btn_desconnect);
            this.groupBox2.Controls.Add(this.btn_sendMessage);
            this.groupBox2.Controls.Add(this.btn_comprovarXarxa);
            this.groupBox2.Location = new System.Drawing.Point(797, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 181);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txb_message
            // 
            this.txb_message.Location = new System.Drawing.Point(161, 115);
            this.txb_message.Name = "txb_message";
            this.txb_message.Size = new System.Drawing.Size(100, 20);
            this.txb_message.TabIndex = 6;
            // 
            // pnl_status
            // 
            this.pnl_status.Location = new System.Drawing.Point(214, 19);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(47, 43);
            this.pnl_status.TabIndex = 5;
            // 
            // lbx_console
            // 
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.Location = new System.Drawing.Point(6, 19);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(120, 69);
            this.lbx_console.TabIndex = 4;
            // 
            // lb_statusInfo
            // 
            this.lb_statusInfo.AutoSize = true;
            this.lb_statusInfo.Location = new System.Drawing.Point(164, 99);
            this.lb_statusInfo.Name = "lb_statusInfo";
            this.lb_statusInfo.Size = new System.Drawing.Size(35, 13);
            this.lb_statusInfo.TabIndex = 3;
            this.lb_statusInfo.Text = "label2";
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.Location = new System.Drawing.Point(186, 141);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_desconnect.TabIndex = 2;
            this.btn_desconnect.Text = "desc";
            this.btn_desconnect.UseVisualStyleBackColor = true;
            this.btn_desconnect.Click += new System.EventHandler(this.btn_desconnect_Click);
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Location = new System.Drawing.Point(32, 141);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_sendMessage.TabIndex = 1;
            this.btn_sendMessage.Text = "send";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(32, 100);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(75, 23);
            this.btn_comprovarXarxa.TabIndex = 0;
            this.btn_comprovarXarxa.Text = "compxarx";
            this.btn_comprovarXarxa.UseVisualStyleBackColor = true;
            this.btn_comprovarXarxa.Click += new System.EventHandler(this.btn_comprovarXarxa_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(-15, -15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(553, 333);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(735, 333);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 19;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(937, 333);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.botoN_MIN1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.botoN_X1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Desencriptar_button);
            this.Controls.Add(this.KeyGenerator_button);
            this.Controls.Add(this.comboPlanets);
            this.Controls.Add(this.ValidationGenerate_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ValidationGenerate_button;
        private Controls03.SWComboFK comboPlanets;
        private System.Windows.Forms.Button KeyGenerator_button;
        private System.Windows.Forms.Button Desencriptar_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Controls03.BOTON_X botoN_X1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Controls03.BOTON_MIN botoN_MIN1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.Button desc;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb_message;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Label lb_statusInfo;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Button btn_comprovarXarxa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

