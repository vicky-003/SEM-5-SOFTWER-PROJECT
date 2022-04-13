using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Margsoftwer
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            groupBox1.Location = new Point((w - groupBox1.Width) / 2, (h - groupBox1.Height) / 2 - 350);
            groupBox2.Location = new Point((w - groupBox2.Width) / 2, (h - groupBox2.Height) / 2 + 20);
        }

        private void Form9_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            groupBox1.Location = new Point((w - groupBox1.Width) / 2, (h - groupBox1.Height) / 2 - 350);
            groupBox2.Location = new Point((w - groupBox2.Width) / 2, (h - groupBox2.Height) / 2 + 20);
          
        }

    
    }
}
