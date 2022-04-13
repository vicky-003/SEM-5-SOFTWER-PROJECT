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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            listBox1.Location = new Point((w - listBox1.Width) / 2, (h - listBox1.Height) / 2 - 50);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form6_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            listBox1.Location = new Point((w - listBox1.Width) / 2, (h - listBox1.Height) / 2 - 50);
        }
    }
}
