﻿namespace Nau
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
            this.swComboFK1 = new Controls03.SWComboFK();
            this.botoN_X1 = new Controls03.BOTON_X();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.CatchKey.Location = new System.Drawing.Point(611, 95);
            this.CatchKey.Name = "CatchKey";
            this.CatchKey.Size = new System.Drawing.Size(126, 45);
            this.CatchKey.TabIndex = 2;
            this.CatchKey.Text = "Public Key";
            this.CatchKey.UseVisualStyleBackColor = true;
            this.CatchKey.Click += new System.EventHandler(this.CatchKey_Click);
            // 
            // swComboFK1
            // 
            this.swComboFK1.CampId = "idPlanet";
            this.swComboFK1.CampMostrar = "DescPlanet";
            this.swComboFK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.swComboFK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.swComboFK1.FormattingEnabled = true;
            this.swComboFK1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.swComboFK1.Location = new System.Drawing.Point(611, 146);
            this.swComboFK1.Name = "swComboFK1";
            this.swComboFK1.nomTaula = "Planets";
            this.swComboFK1.Size = new System.Drawing.Size(121, 24);
            this.swComboFK1.TabIndex = 3;
            // 
            // botoN_X1
            // 
            this.botoN_X1.BackColor = System.Drawing.Color.Transparent;
            this.botoN_X1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botoN_X1.BackgroundImage")));
            this.botoN_X1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botoN_X1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoN_X1.FlatAppearance.BorderSize = 0;
            this.botoN_X1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoN_X1.Location = new System.Drawing.Point(1599, 95);
            this.botoN_X1.Name = "botoN_X1";
            this.botoN_X1.Size = new System.Drawing.Size(20, 20);
            this.botoN_X1.TabIndex = 4;
            this.botoN_X1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(828, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 302);
            this.dataGridView1.TabIndex = 5;
            // 
            // Comandaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1848, 970);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botoN_X1);
            this.Controls.Add(this.swComboFK1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_comprovarXarxa;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Button CatchKey;
        private Controls03.SWComboFK swComboFK1;
        private Controls03.BOTON_X botoN_X1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}