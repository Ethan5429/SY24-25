using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] bits = new int[8];

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            bits[0] = 0;
            bits[1] = 0;
            bits[2] = 0;
            bits[3] = 0;
            bits[4] = 0;
            bits[5] = 0;
            bits[6] = 0;
            bits[7] = 0;
            if (textBox1.Text == "1") { bits[0] = 1; }
            if (textBox2.Text == "1") { bits[1] = 1; }
            if (textBox3.Text == "1") { bits[2] = 1; }
            if (textBox4.Text == "1") { bits[3] = 1; }
            if (textBox5.Text == "1") { bits[4] = 1; }
            if (textBox6.Text == "1") { bits[5] = 1; }
            if (textBox7.Text == "1") { bits[6] = 1; }
            if (textBox8.Text == "1") { bits[7] = 1; }
            Calc();
        }

        private void Calc()
        {
            int sum = 0;
            if (bits[0] != 0) { sum += 128; }
            if (bits[1] != 0) { sum += 64; }
            if (bits[2] != 0) { sum += 32; }
            if (bits[3] != 0) { sum += 16; }
            if (bits[4] != 0) { sum += 8; }
            if (bits[5] != 0) { sum += 4; }
            if (bits[6] != 0) { sum += 2; }
            if (bits[7] != 0) { sum += 1; }
            label1.Text = sum.ToString();
        }
    }
}
