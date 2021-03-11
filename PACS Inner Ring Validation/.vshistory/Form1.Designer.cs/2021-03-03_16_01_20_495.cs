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
            this.SuspendLayout();
            // 
            // ValidationGenerate_button
            // 
            this.ValidationGenerate_button.BackColor = System.Drawing.Color.Transparent;
            this.ValidationGenerate_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ValidationGenerate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValidationGenerate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationGenerate_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.ValidationGenerate_button.Location = new System.Drawing.Point(767, 167);
            this.ValidationGenerate_button.Name = "ValidationGenerate_button";
            this.ValidationGenerate_button.Size = new System.Drawing.Size(174, 30);
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
            this.comboPlanets.Location = new System.Drawing.Point(776, 111);
            this.comboPlanets.Name = "comboPlanets";
            this.comboPlanets.nomTaula = "Planets";
            this.comboPlanets.Size = new System.Drawing.Size(149, 26);
            this.comboPlanets.TabIndex = 5;
            // 
            // KeyGenerator_button
            // 
            this.KeyGenerator_button.BackColor = System.Drawing.Color.Transparent;
            this.KeyGenerator_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.KeyGenerator_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KeyGenerator_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyGenerator_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.KeyGenerator_button.Location = new System.Drawing.Point(767, 212);
            this.KeyGenerator_button.Name = "KeyGenerator_button";
            this.KeyGenerator_button.Size = new System.Drawing.Size(174, 30);
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
            this.Desencriptar_button.Location = new System.Drawing.Point(767, 255);
            this.Desencriptar_button.Name = "Desencriptar_button";
            this.Desencriptar_button.Size = new System.Drawing.Size(174, 30);
            this.Desencriptar_button.TabIndex = 7;
            this.Desencriptar_button.Text = "Desencriptar";
            this.Desencriptar_button.UseVisualStyleBackColor = false;
            this.Desencriptar_button.Click += new System.EventHandler(this.Desencriptar_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 111);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
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
            this.botoN_X1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_X1.Location = new System.Drawing.Point(1331, 8);
            this.botoN_X1.Name = "botoN_X1";
            this.botoN_X1.Size = new System.Drawing.Size(27, 27);
            this.botoN_X1.TabIndex = 10;
            this.botoN_X1.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(203)))), ((int)(((byte)(207)))));
            this.progressBar1.Location = new System.Drawing.Point(959, 595);
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
            this.botoN_MIN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_MIN1.Location = new System.Drawing.Point(1294, 8);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

