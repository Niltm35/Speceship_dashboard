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
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.btn_comprovarXarxa = new System.Windows.Forms.Button();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.lb_statusInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb_message = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.desc = new System.Windows.Forms.Button();
            this.conectar = new System.Windows.Forms.Button();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValidationGenerate_button
            // 
            this.ValidationGenerate_button.BackColor = System.Drawing.Color.Transparent;
            this.ValidationGenerate_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ValidationGenerate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValidationGenerate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationGenerate_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.ValidationGenerate_button.Location = new System.Drawing.Point(136, 225);
            this.ValidationGenerate_button.Margin = new System.Windows.Forms.Padding(4);
            this.ValidationGenerate_button.Name = "ValidationGenerate_button";
            this.ValidationGenerate_button.Size = new System.Drawing.Size(232, 37);
            this.ValidationGenerate_button.TabIndex = 1;
            this.ValidationGenerate_button.Text = "ValidationCode";
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
            this.comboPlanets.Location = new System.Drawing.Point(871, 392);
            this.comboPlanets.Margin = new System.Windows.Forms.Padding(4);
            this.comboPlanets.Name = "comboPlanets";
            this.comboPlanets.nomTaula = "Planets";
            this.comboPlanets.Size = new System.Drawing.Size(197, 32);
            this.comboPlanets.TabIndex = 5;
            // 
            // KeyGenerator_button
            // 
            this.KeyGenerator_button.BackColor = System.Drawing.Color.Transparent;
            this.KeyGenerator_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.KeyGenerator_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyGenerator_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyGenerator_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.KeyGenerator_button.Location = new System.Drawing.Point(136, 280);
            this.KeyGenerator_button.Margin = new System.Windows.Forms.Padding(4);
            this.KeyGenerator_button.Name = "KeyGenerator_button";
            this.KeyGenerator_button.Size = new System.Drawing.Size(232, 37);
            this.KeyGenerator_button.TabIndex = 6;
            this.KeyGenerator_button.Text = "PublicKey";
            this.KeyGenerator_button.UseVisualStyleBackColor = false;
            this.KeyGenerator_button.Click += new System.EventHandler(this.KeyGenerator_button_Click);
            // 
            // Desencriptar_button
            // 
            this.Desencriptar_button.BackColor = System.Drawing.Color.Transparent;
            this.Desencriptar_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Desencriptar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desencriptar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desencriptar_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.Desencriptar_button.Location = new System.Drawing.Point(136, 333);
            this.Desencriptar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Desencriptar_button.Name = "Desencriptar_button";
            this.Desencriptar_button.Size = new System.Drawing.Size(232, 37);
            this.Desencriptar_button.TabIndex = 7;
            this.Desencriptar_button.Text = "Desencriptar";
            this.Desencriptar_button.UseVisualStyleBackColor = false;
            this.Desencriptar_button.Click += new System.EventHandler(this.Desencriptar_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(391, 134);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 136);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(391, 288);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 254);
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
            this.botoN_X1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_X1.Location = new System.Drawing.Point(1775, 10);
            this.botoN_X1.Margin = new System.Windows.Forms.Padding(4);
            this.botoN_X1.Name = "botoN_X1";
            this.botoN_X1.Size = new System.Drawing.Size(36, 33);
            this.botoN_X1.TabIndex = 10;
            this.botoN_X1.Text = " ";
            this.botoN_X1.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.progressBar1.Location = new System.Drawing.Point(1279, 732);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(145, 17);
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
            this.botoN_MIN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_MIN1.Location = new System.Drawing.Point(1725, 10);
            this.botoN_MIN1.Margin = new System.Windows.Forms.Padding(4);
            this.botoN_MIN1.Name = "botoN_MIN1";
            this.botoN_MIN1.Size = new System.Drawing.Size(36, 33);
            this.botoN_MIN1.TabIndex = 12;
            this.botoN_MIN1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Location = new System.Drawing.Point(174, 59);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(129, 27);
            this.btn_sendMessage.TabIndex = 14;
            this.btn_sendMessage.Text = "Send Message";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(17, 35);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(129, 27);
            this.btn_comprovarXarxa.TabIndex = 15;
            this.btn_comprovarXarxa.Text = "Comprovar Xarxa";
            this.btn_comprovarXarxa.UseVisualStyleBackColor = true;
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.Location = new System.Drawing.Point(1526, 442);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(129, 28);
            this.btn_desconnect.TabIndex = 16;
            this.btn_desconnect.Text = "Desconnect";
            this.btn_desconnect.UseVisualStyleBackColor = true;
            // 
            // pnl_status
            // 
            this.pnl_status.Location = new System.Drawing.Point(17, 93);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(68, 60);
            this.pnl_status.TabIndex = 17;
            // 
            // lbx_console
            // 
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.ItemHeight = 16;
            this.lbx_console.Location = new System.Drawing.Point(110, 69);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(193, 84);
            this.lbx_console.TabIndex = 18;
            // 
            // lb_statusInfo
            // 
            this.lb_statusInfo.AutoSize = true;
            this.lb_statusInfo.Location = new System.Drawing.Point(149, 40);
            this.lb_statusInfo.Name = "lb_statusInfo";
            this.lb_statusInfo.Size = new System.Drawing.Size(46, 17);
            this.lb_statusInfo.TabIndex = 19;
            this.lb_statusInfo.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_comprovarXarxa);
            this.groupBox1.Controls.Add(this.pnl_status);
            this.groupBox1.Controls.Add(this.lb_statusInfo);
            this.groupBox1.Controls.Add(this.lbx_console);
            this.groupBox1.Location = new System.Drawing.Point(1329, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 176);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "comprobaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_message);
            this.groupBox2.Controls.Add(this.btn_sendMessage);
            this.groupBox2.Location = new System.Drawing.Point(1329, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 177);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "enviar datos";
            // 
            // txb_message
            // 
            this.txb_message.Location = new System.Drawing.Point(13, 113);
            this.txb_message.Multiline = true;
            this.txb_message.Name = "txb_message";
            this.txb_message.Size = new System.Drawing.Size(290, 53);
            this.txb_message.TabIndex = 24;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.desc);
            this.groupBox5.Controls.Add(this.conectar);
            this.groupBox5.Controls.Add(this.lbx_Missatges);
            this.groupBox5.Location = new System.Drawing.Point(871, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(452, 284);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Servidor";
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(79, 50);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(106, 23);
            this.desc.TabIndex = 3;
            this.desc.Text = "desconectar";
            this.desc.UseVisualStyleBackColor = true;
            // 
            // conectar
            // 
            this.conectar.Location = new System.Drawing.Point(79, 21);
            this.conectar.Name = "conectar";
            this.conectar.Size = new System.Drawing.Size(106, 23);
            this.conectar.TabIndex = 2;
            this.conectar.Text = "conectar";
            this.conectar.UseVisualStyleBackColor = true;
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 16;
            this.lbx_Missatges.Location = new System.Drawing.Point(191, 21);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(237, 244);
            this.lbx_Missatges.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_desconnect);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Button btn_comprovarXarxa;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Label lb_statusInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb_message;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button desc;
        private System.Windows.Forms.Button conectar;
        private System.Windows.Forms.ListBox lbx_Missatges;
    }
}

