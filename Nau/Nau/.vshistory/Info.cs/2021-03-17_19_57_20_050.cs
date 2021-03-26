using System;
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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        public string INFO;
        public string ICON;
        private void Info_Load(object sender, EventArgs e)
        {
            lbl_message.Text = INFO;
            img_icon.Image = Image.FromFile(Application.StartupPath + @"\imatges\" + ICON); ;
        }
    }
}
