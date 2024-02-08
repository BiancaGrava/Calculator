using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grava_Bianca_exercitii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool nverif(string s)
        {
            if (s == "")
                return true;
            
            return false;
        }
        private bool nnr(string s)
        {
            foreach (char c in s)
                if (c < '0' || c > '9')
                    return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (nverif(textBox5.Text))
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                int a, b, rez = 0, c,nre,nrc,nri;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox3.Text);
                if (textBox2.Text == "+")
                    rez = a + b;
                else
                {
                    if (textBox2.Text == "-")
                        rez = a - b;
                    else
                    {
                        if (textBox2.Text == "/")
                        {
                            rez = a / b; if (b == 0)
                            {
                                Form5 f = new Form5();
                                f.Show();
                            }
                        }
                        else if (textBox2.Text == "*") rez = a * b;
                    }

                    
                }
                if (nnr(textBox5.Text))
                {
                    Form3 f = new Form3();
                    f.Show();
                }
                else
                {
                    c = Convert.ToInt32(textBox5.Text);
                    if (c == rez)
                    {
                        Form2 f = new Form2();
                        f.Show();
                    }
                    else
                    {
                        Form3 f = new Form3();
                        f.Show();
                    }
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Text = String.Empty;
            int x, op;
            Random rx, rop;
            rx = new Random();
            rop = new Random();
            x = rx.Next(1, 10);
            op = rop.Next(1, 5);
            textBox1.Text = Convert.ToString(x);
            x = rx.Next(1, 10);
            textBox3.Text = Convert.ToString(x);
            if (op == 1)
                textBox2.Text = "+";
            else
            {
                if (op == 2)
                    textBox2.Text = "-";
                else { 
                if (op == 3)
                    textBox2.Text = "*";
                else
                        if (op == 4)
                        textBox2.Text = "/";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
