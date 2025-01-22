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
        int[] bits2 = new int[8];
        int[] bits3 = new int[8];

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Calc()
        {
            //clear the total
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
            int sum = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] != 0) 
                { sum += (int)Math.Pow(2,7-i); }
            }
            label1.Text = sum.ToString();
           
            bits2[0] = 0;
            bits2[1] = 0;
            bits2[2] = 0;
            bits2[3] = 0;
            bits2[4] = 0;
            bits2[5] = 0;
            bits2[6] = 0;
            bits2[7] = 0;
            if (textBox9.Text == "1") { bits2[0] = 1; }
            if (textBox10.Text == "1") { bits2[1] = 1; }
            if (textBox11.Text == "1") { bits2[2] = 1; }
            if (textBox12.Text == "1") { bits2[3] = 1; }
            if (textBox13.Text == "1") { bits2[4] = 1; }
            if (textBox14.Text == "1") { bits2[5] = 1; }
            if (textBox15.Text == "1") { bits2[6] = 1; }
            if (textBox16.Text == "1") { bits2[7] = 1; }
            int sum2 = 0;
            for (int i = 0; i < bits2.Length; i++)
            {
                if (bits2[i] != 0)
                { sum2 += (int)Math.Pow(2, 7 - i); }
            }
            label2.Text = sum2.ToString();

            bits3[0] = 0;
            bits3[1] = 0;
            bits3[2] = 0;
            bits3[3] = 0;
            bits3[4] = 0;
            bits3[5] = 0;
            bits3[6] = 0;
            bits3[7] = 0;
            if (textBox17.Text == "1") { bits3[0] = 1; }
            if (textBox18.Text == "1") { bits3[1] = 1; }
            if (textBox19.Text == "1") { bits3[2] = 1; }
            if (textBox20.Text == "1") { bits3[3] = 1; }
            if (textBox21.Text == "1") { bits3[4] = 1; }
            if (textBox22.Text == "1") { bits3[5] = 1; }
            if (textBox23.Text == "1") { bits3[6] = 1; }
            if (textBox24.Text == "1") { bits3[7] = 1; }
            int sum3 = 0;
            for (int i = 0; i < bits3.Length; i++)
            {
                if (bits3[i] != 0)
                { sum3 += (int)Math.Pow(2, 7 - i); }
            }
            label3.Text = sum3.ToString();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "0")
            { ((TextBox)sender).Text = "1"; }
            else
            { ((TextBox)sender).Text = "0"; }
            Calc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                bits[i] = 0;
                update();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits2.Length; i++)
            {
                bits2[i] = 0;
                update();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {for (int i = 0; i < bits3.Length; i++)
            {
                bits3[i] = 0;
                update();
            }
        }

        private void update()
        {
            textBox1.Text = (bits[0] == 1 ? "1" : "0");
            textBox2.Text = (bits[1] == 1 ? "1" : "0");
            textBox3.Text = (bits[2] == 1 ? "1" : "0");
            textBox4.Text = (bits[3] == 1 ? "1" : "0");
            textBox5.Text = (bits[4] == 1 ? "1" : "0");
            textBox6.Text = (bits[5] == 1 ? "1" : "0");
            textBox7.Text = (bits[6] == 1 ? "1" : "0");
            textBox8.Text = (bits[7] == 1 ? "1" : "0");
            textBox9.Text = (bits2[0] == 1 ? "1" : "0");
            textBox10.Text = (bits2[1] == 1 ? "1" : "0");
            textBox11.Text = (bits2[2] == 1 ? "1" : "0");
            textBox12.Text = (bits2[3] == 1 ? "1" : "0");
            textBox13.Text = (bits2[4] == 1 ? "1" : "0");
            textBox14.Text = (bits2[5] == 1 ? "1" : "0");
            textBox15.Text = (bits2[6] == 1 ? "1" : "0");
            textBox16.Text = (bits2[7] == 1 ? "1" : "0"); 
            textBox17.Text = (bits3[0] == 1 ? "1" : "0");
            textBox18.Text = (bits3[1] == 1 ? "1" : "0");
            textBox19.Text = (bits3[2] == 1 ? "1" : "0");
            textBox20.Text = (bits3[3] == 1 ? "1" : "0");
            textBox21.Text = (bits3[4] == 1 ? "1" : "0");
            textBox22.Text = (bits3[5] == 1 ? "1" : "0");
            textBox23.Text = (bits3[6] == 1 ? "1" : "0");
            textBox24.Text = (bits3[7] == 1 ? "1" : "0");
            Calc();
        }

        private void ShiftL1button_Click(object sender, EventArgs e)
        {
            bits[0] = 0;
            for (int i = 1; i < bits.Length; i++)
            {
                if (bits[i] == 1)
                {
                    bits[i] = 0;
                    bits[i - 1] = 1;
                }
                update();
            }
        }

        private void ShiftR1button_Click(object sender, EventArgs e)
        {
            bits[7] = 0;
            for (int i = 6; i > -1; i--)
            {
                if (bits[i] == 1)
                {
                    bits[i] = 0;
                    bits[i + 1] = 1;
                }
                update();
            }
        }

        private void ShiftL2button_Click(object sender, EventArgs e)
        {
            bits2[0] = 0;
            for (int i = 1; i < bits2.Length; i++)
            {
                if (bits2[i] == 1)
                {
                    bits2[i] = 0;
                    bits2[i - 1] = 1;
                }
                update();
            }
        }

        private void ShiftR2button_Click(object sender, EventArgs e)
        {
            bits2[7] = 0;
            for (int i = 6; i > -1; i--)
            {
                if (bits2[i] == 1)
                {
                    bits2[i] = 0;
                    bits2[i + 1] = 1;
                }
                update();
            }
        }

        private void Andbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 && bits2[i] == 1)
                {
                    bits3[i] = 1;
                }
                else { bits3[i] = 0; }
                update();
            }
        }

        private void Orbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 || bits2[i] == 1)
                {
                    bits3[i] = 1;
                }
                else { bits3[i] = 0; }
                update();
            }
        }

        private void XOrbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 || bits2[i] == 1)
                {
                    bits3[i] = 1;
                    if (bits[i] == 1 && bits2[i] == 1)
                    {
                        bits3[i] = 0;
                    }
                }
                else { bits3[i] = 0; }
                update();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 && bits2[i] == 1)
                {
                    if (i == 0) { bits3[i] = 0; }
                    else { bits3[i - 1] = 1; }
                }
                else if (bits[i] == 1 || bits2[i] == 1)
                {
                    bits3[i] = 1;
                }
                else { bits3[i] = 0; }
                update();
            }
        }
    }
}
