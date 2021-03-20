using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

 

        private void scrollall(object sender, ScrollEventArgs e)
        {

            pictureBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            label7.Text = vScrollBar1.Value.ToString();
            label8.Text = vScrollBar2.Value.ToString();
            label9.Text = vScrollBar3.Value.ToString();
        }
    }
}
