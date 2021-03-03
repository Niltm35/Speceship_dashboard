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
            this.SuspendLayout();
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.BackColor = System.Drawing.Color.Transparent;
            this.btn_comprovarXarxa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_comprovarXarxa.BackgroundImage")));
            this.btn_comprovarXarxa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_comprovarXarxa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(205, 95);
            this.btn_comprovarXarxa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(120, 111);
            this.btn_comprovarXarxa.TabIndex = 0;
            this.btn_comprovarXarxa.UseVisualStyleBackColor = false;
            this.btn_comprovarXarxa.Click += new System.EventHandler(this.btn_comprovarXarxa_Click);
            // 
            // pnl_status
            // 
            this.pnl_status.BackColor = System.Drawing.Color.Red;
            this.pnl_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_status.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_status.Location = new System.Drawing.Point(219, 236);
            this.pnl_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(92, 54);
            this.pnl_status.TabIndex = 1;
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.SystemColors.MenuText;
            this.lbx_console.ForeColor = System.Drawing.SystemColors.Window;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.ItemHeight = 16;
            this.lbx_console.Location = new System.Drawing.Point(365, 95);
            this.lbx_console.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(144, 196);
            this.lbx_console.TabIndex = 1;
            // 
            // CatchKey
            // 
            this.CatchKey.BackColor = System.Drawing.Color.Transparent;
            this.CatchKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CatchKey.BackgroundImage")));
            this.CatchKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CatchKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatchKey.Location = new System.Drawing.Point(978, 96);
            this.CatchKey.Name = "CatchKey";
            this.CatchKey.Size = new System.Drawing.Size(120, 120);
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
            this.comboPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPlanet.ForeColor = System.Drawing.Color.LightGray;
            this.comboPlanet.FormattingEnabled = true;
            this.comboPlanet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboPlanet.Location = new System.Drawing.Point(1147, 101);
            this.comboPlanet.Name = "comboPlanet";
            this.comboPlanet.nomTaula = "Planets";
            this.comboPlanet.Size = new System.Drawing.Size(171, 33);
            this.comboPlanet.Sorted = true;
            this.comboPlanet.TabIndex = 3;
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
            this.botoN_X1.UseVisualStyleBackColor = false;
            // 
            // ValidationCode
            // 
            this.ValidationCode.BackColor = System.Drawing.Color.Black;
            this.ValidationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValidationCode.ForeColor = System.Drawing.Color.LightGray;
            this.ValidationCode.Location = new System.Drawing.Point(1147, 146);
            this.ValidationCode.Multiline = true;
            this.ValidationCode.Name = "ValidationCode";
            this.ValidationCode.Size = new System.Drawing.Size(269, 47);
            this.ValidationCode.TabIndex = 5;
            // 
            // ValidationCode_Codificado
            // 
            this.ValidationCode_Codificado.BackColor = System.Drawing.Color.Black;
            this.ValidationCode_Codificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValidationCode_Codificado.ForeColor = System.Drawing.Color.LightGray;
            this.ValidationCode_Codificado.Location = new System.Drawing.Point(1147, 219);
            this.ValidationCode_Codificado.Multiline = true;
            this.ValidationCode_Codificado.Name = "ValidationCode_Codificado";
            this.ValidationCode_Codificado.Size = new System.Drawing.Size(268, 159);
            this.ValidationCode_Codificado.TabIndex = 6;
            // 
            // Codificar
            // 
            this.Codificar.BackColor = System.Drawing.Color.Transparent;
            this.Codificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Codificar.BackgroundImage")));
            this.Codificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Codificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Codificar.Location = new System.Drawing.Point(978, 236);
            this.Codificar.Name = "Codificar";
            this.Codificar.Size = new System.Drawing.Size(120, 120);
            this.Codificar.TabIndex = 7;
            this.Codificar.UseVisualStyleBackColor = false;
            this.Codificar.Click += new System.EventHandler(this.Codificar_Click);
            // 
            // Comandaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.ControlBox = false;
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Comandaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Comandaments_Load);
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
    }
}