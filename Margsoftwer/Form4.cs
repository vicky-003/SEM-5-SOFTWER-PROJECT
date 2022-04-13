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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void Form4_Load(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            groupBox1.Location = new Point((w - groupBox1.Width) / 2, (h - groupBox1.Height) / 2 - 50);
            dataGridView1.Location = new Point((w - dataGridView1.Width) / 2, (h - dataGridView1.Height) / 2 +50);
        }

        private void Form4_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            groupBox1.Location = new Point((w - groupBox1.Width) / 2, (h - groupBox1.Height) / 2 - 50);
            dataGridView1.Location = new Point((w - dataGridView1.Width) / 2, (h - dataGridView1.Height) / 2 + 50);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
