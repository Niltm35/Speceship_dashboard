﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nau
{
    public partial class Warning : Form
    {
        public Warning()
        {
            InitializeComponent();
        }

        public string INFO;
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_message.Text = INFO;
        }
    }
}
