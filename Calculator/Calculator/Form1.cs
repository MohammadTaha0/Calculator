using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string op = "";
        double num = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = btn.Text;
            }
            else
            {
                textBox1.Text += btn.Text;
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btnop = (Button)sender;
            op = btnop.Text;

            textBox1.Text += " " + op + " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {

            string[] arrayText = textBox1.Text.Split(' ');
            double num = 0;
            for (int i = 0; i < (arrayText.Length); i++)
            {
                if (arrayText[i] == "+")
                {
                    num += Convert.ToDouble(arrayText[i + 1]);
                    i++;
                }
                else if (arrayText[i] == "-")
                {
                    num -= Convert.ToDouble(arrayText[i + 1]);
                    i++;
                }
                else if (arrayText[i] == "÷")
                {
                    num /= Convert.ToDouble(arrayText[i + 1]);
                    i++;
                }
                else if (arrayText[i] == "x")
                {
                    num *= Convert.ToDouble(arrayText[i + 1]);
                    i++;
                }
                else
                {
                    num += Convert.ToDouble(arrayText[i]);
                }
                //MessageBox.Show(arrayText[i+1]);
                //MessageBox.Show(arrayText[i+2]);
                //ans = arrayText[ans];
                //ans1 = arrayText[ans+1];
                //ans2 = arrayText[ans+2];
                //MessageBox.Show(ans);
                //MessageBox.Show(ans1);
                //MessageBox.Show(Convert.ToInt16(arrayText[0]));
            }
            textBox1.Text = "" + num;

            //if (op == "+")
            //{
            //    num += Convert.ToDouble(textBox1.Text);
            //}
            //else if (op == "-")
            //{
            //    num -= Convert.ToDouble(textBox1.Text);
            //}
            //else if (op == "÷")
            //{
            //    num /= Convert.ToDouble(textBox1.Text);
            //}
            //else if (op == "x")
            //{
            //    num *= Convert.ToDouble(textBox1.Text);
            //}
            //textBox1.Text = "" + num;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if ("" + textBox1.Text[textBox1.TextLength - 1] != ".")
            {
                textBox1.Text += ".";
            }

        }
    }
}
