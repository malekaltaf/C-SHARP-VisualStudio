using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrollbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveclr(object sender, ScrollEventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            label1.Text = hScrollBar1.Value.ToString();
            label2.Text = hScrollBar2.Value.ToString();
            label3.Text = hScrollBar3.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }
    }
}
