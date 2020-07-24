using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //////  public static double (double x,double y)
        ////    {
        ////     Console.WriteLine(y - y / x - x);
        ////     double s = (y - y / x - x);
        ////     return s;
        ///     }
        //       if 
        //         {
        //           Console.WriteLine((x1 / x2) / (x3 / x4) == (y1 / y2) / (y3 / y4));
        //           double s = ((x1 / x2) / (x3 / x4) == (y1 / y2) / (y3 / y4));
        //           return s;
        ////       }


        double x1, x2, x3, x4, y1, y2, y3, y4, s1, s2;


        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                textBox9.Text = ("Boş alan bırakmayınız!");
                return;
            }
            {
                x1 = Convert.ToDouble(textBox1.Text);
                y1 = Convert.ToDouble(textBox3.Text);
                x2 = Convert.ToDouble(textBox2.Text);
                y2 = Convert.ToDouble(textBox4.Text);
                s1 = ((y2 - y1) /( x2 - x1));
                textBox9.Text = Convert.ToString(s1);
                x3 = Convert.ToDouble(textBox5.Text);
                y3 = Convert.ToDouble(textBox7.Text);
                x4 = Convert.ToDouble(textBox6.Text);
                y4 = Convert.ToDouble(textBox8.Text);
                s2 = ((y4 - y3 )/( x4 - x3));
                textBox9.Text = Convert.ToString(s2);
                if ((s1 * s2) == -1)
                {
                    textBox9.Text = ("Bu doğrular diktir.");
                }
                else if ((s1 * s2 )!= -1)
                {
                    textBox9.Text = ("Bu doğrular kesişiktir.");
                }
                else
                {
                    if ((x1 / x2) / (x3 / x4) == (y1 / y2) / (y3 / y4))
                        textBox9.Text = ("Bu doğrular paraleldir.");

                    else if ((x1 / x2) / (x3 / x4) != (y1 / y2) / (y3 / y4))
                        textBox9.Text = ("Bu doğrular çakışık paraleldir.");
                    else
                    {
                        textBox9.Text = ("Doğru durumu bulunamadı!!!");
                    }
                }
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((((!char.IsDigit(e.KeyChar) && e.KeyChar != 45 && e.KeyChar != 44)) && e.KeyChar != 8)))
            {
                e.Handled = true;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
