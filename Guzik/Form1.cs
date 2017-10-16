using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Guzik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Tekst = "Wyłączony";
            this.button1.Enabled = false;
        }

        private void przycisk1_Click(object sender, EventArgs e)
        {
            if (this.button1.Enabled == false)
            {
                this.button1.Enabled = true;
            }
        }

        private void przycisk2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Naciśnięto "+((przycisk)sender).Name+" !!!");
        }

        private void przycisk3_Click(object sender, EventArgs e)
        {
            przycisk2_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
