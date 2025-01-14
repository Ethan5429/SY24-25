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

        int[] bits = new int[24];

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

            bits[8] = 0;
            bits[9] = 0;
            bits[10] = 0;
            bits[11] = 0;
            bits[12] = 0;
            bits[13] = 0;
            bits[14] = 0;
            bits[15] = 0;
            if (textBox9.Text == "1") { bits[8] = 1; }
            if (textBox10.Text == "1") { bits[9] = 1; }
            if (textBox11.Text == "1") { bits[10] = 1; }
            if (textBox12.Text == "1") { bits[11] = 1; }
            if (textBox13.Text == "1") { bits[12] = 1; }
            if (textBox14.Text == "1") { bits[13] = 1; }
            if (textBox15.Text == "1") { bits[14] = 1; }
            if (textBox16.Text == "1") { bits[15] = 1; }

            bits[16] = 0;
            bits[17] = 0;
            bits[18] = 0;
            bits[19] = 0;
            bits[20] = 0;
            bits[21] = 0;
            bits[22] = 0;
            bits[23] = 0;
            if (textBox17.Text == "1") { bits[16] = 1; }
            if (textBox18.Text == "1") { bits[17] = 1; }
            if (textBox19.Text == "1") { bits[18] = 1; }
            if (textBox20.Text == "1") { bits[19] = 1; }
            if (textBox21.Text == "1") { bits[20] = 1; }
            if (textBox22.Text == "1") { bits[21] = 1; }
            if (textBox23.Text == "1") { bits[22] = 1; }
            if (textBox24.Text == "1") { bits[23] = 1; }
            Calc();
        }

        private void Calc()
        {
            //clear the total
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

            int sum2 = 0;
            if (bits[8] != 0) { sum2 += 128; }
            if (bits[9] != 0) { sum2 += 64; }
            if (bits[10] != 0) { sum2 += 32; }
            if (bits[11] != 0) { sum2 += 16; }
            if (bits[12] != 0) { sum2 += 8; }
            if (bits[13] != 0) { sum2 += 4; }
            if (bits[14] != 0) { sum2 += 2; }
            if (bits[15] != 0) { sum2 += 1; }
            label2.Text = sum2.ToString();

            int sum3 = 0;
            if (bits[16] != 0) { sum3 += 128; }
            if (bits[17] != 0) { sum3 += 64; }
            if (bits[18] != 0) { sum3 += 32; }
            if (bits[19] != 0) { sum3 += 16; }
            if (bits[20] != 0) { sum3 += 8; }
            if (bits[21] != 0) { sum3 += 4; }
            if (bits[22] != 0) { sum3 += 2; }
            if (bits[23] != 0) { sum3 += 1; }
            label3.Text = sum3.ToString();
        }

        
    }
}
