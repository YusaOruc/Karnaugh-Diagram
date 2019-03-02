using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karnaugh_Diyagramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        public void button26_Click(object sender, EventArgs e)
        {
            string[] olusan = textBox1.Text.Split(',');
            if (textBox1.Text != "")
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                button7.Text = "0";
                //aaaaaaaaaaaaaaaaaaaaaaaa
                if (olusan[5] == "+")
                {
                    button8.Text = "1";
                }
                else
                {
                    button8.Text = "0";
                }
                //aaaaaaaaaaaaaaaaaaaaaaaaaaaaa
                if (olusan[3] == "x")
                {
                    button9.Text = "0";
                }
                else
                {
                    button9.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[3] == "x" || olusan[5] == "x")
                {
                    button10.Text = "0";
                }
                else
                {
                    button10.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[1] == "x" || olusan[3] == "x")
                {
                    button12.Text = "0";
                }
                else
                {
                    button12.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[5] == "+")
                {
                    button13.Text = "1";
                }
                else if (olusan[1] == "+" && olusan[3] == "+")
                {
                    button13.Text = "1";
                }
                else
                {
                    button13.Text = "0";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[1] == "x" && olusan[3] == "x" && olusan[5] == "x")
                {
                    button14.Text = "0";
                }
                else
                {
                    button14.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[5] == "x")
                {
                    button15.Text = "0";
                }
                else if (olusan[1] == "x" && olusan[3] == "3")
                {
                    button15.Text = "0";
                }
                else if (olusan[3] == "+" && olusan[5] == "+")
                {
                    button15.Text = "1";
                }
                else if (olusan[1] == "+" && olusan[3] == "x" && olusan[5] == "+")
                {
                    button15.Text = "1";
                }
                else
                {
                    button15.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[3] == "x" || olusan[5] == "x")
                {
                    button17.Text = "0";
                }
                else
                {
                    button17.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[3] == "x" && olusan[5] == "+")
                {
                    button18.Text = "1";
                }
                else if (olusan[3] == "x")
                {
                    button18.Text = "0";
                }
                else
                {
                    button18.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                button19.Text = "1";
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[5] == "x")
                {
                    button20.Text = "0";
                }
                else
                {
                    button20.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[1] == "+" && olusan[3] == "+" && olusan[3] == "+")
                {
                    button22.Text = "1";
                }
                else
                {
                    button22.Text = "0";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[1] == "x" && olusan[3] == "x")
                {
                    button23.Text = "0";
                }
                else if (olusan[5] == "+")
                {
                    button23.Text = "1";
                }
                else if (olusan[1] == "+" && olusan[3] == "x" && olusan[3] == "x")
                {
                    button23.Text = "0";
                }
                else
                {
                    button23.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[1] == "+")
                {
                    button24.Text = "1";
                }
                else if (olusan[1] == "x" && olusan[3] == "x" && olusan[3] == "x")
                {
                    button24.Text = "0";

                }
                else
                {
                    button24.Text = "1";
                }
                //aaaaaaaaaaaaaaaaaaaaa
                if (olusan[5] == "x")
                {
                    button25.Text = "0";
                }
                else if (olusan[1] == "x" && olusan[3] == "x" && olusan[3] == "+")
                {
                    button25.Text = "0";
                }
                else
                {
                    button25.Text = "1";
                }



            }
            else
            {
                MessageBox.Show("Lütfen fonksiyonu giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



        }

        private void button7_Click(object sender, EventArgs e)

        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if(button7.Text=="1"&& button8.Text == "1" && button12.Text == "1" && button13.Text == "1")
            {
                listBox2.Items.Add("(a.c)+");
            }
            if(button8.Text == "1" && button9.Text == "1" && button13.Text == "1" && button14.Text == "1")
            {
                listBox2.Items.Add("(a.d)+");
            }
            if (button9.Text == "1" && button10.Text == "1" && button14.Text == "1" && button15.Text == "1")
            {
                listBox2.Items.Add("(a.c)+");
            }
            if (button12.Text == "1" && button13.Text == "1" && button17.Text == "1" && button18.Text == "1")
            {
                listBox2.Items.Add("(b.c)+");
            }
            if (button13.Text == "1" && button14.Text == "1" && button18.Text == "1" && button19.Text == "1")
            {
                listBox2.Items.Add("(b.d)+");
            }
            if (button14.Text == "1" && button15.Text == "1" && button19.Text == "1" && button20.Text == "1")
            {
                listBox2.Items.Add("(b.c)+");
            }
            if (button17.Text == "1" && button18.Text == "1" && button22.Text == "1" && button23.Text == "1")
            {
                listBox2.Items.Add("(a.c)+");
            }
            if (button18.Text == "1" && button19.Text == "1" && button23.Text == "1" && button24.Text == "1")
            {
                listBox2.Items.Add("(a.d)+");
            }
            if (button19.Text == "1" && button20.Text == "1" && button24.Text == "1" && button25.Text == "1")
            {
                listBox2.Items.Add("(a.c)+");
            }



        }

        private void button28_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (button7.Text == "0" && button8.Text == "0" && button12.Text == "0" && button13.Text == "0")
            {
                listBox1.Items.Add("(a.c)+");
            }
            if (button8.Text == "0" && button9.Text == "0" && button13.Text == "0" && button14.Text == "0")
            {
                listBox1.Items.Add("(a.d)+");
            }
            if (button9.Text == "0" && button10.Text == "0" && button14.Text == "0" && button15.Text == "0")
            {
                listBox1.Items.Add("(a.c)+");
            }
            if (button12.Text == "0" && button13.Text == "0" && button17.Text == "0" && button18.Text == "0")
            {
                listBox1.Items.Add("(b.c)+");
            }
            if (button13.Text == "0" && button14.Text == "0" && button18.Text == "0" && button19.Text == "0")
            {
                listBox1.Items.Add("(b.d)+");
            }
            if (button14.Text == "0" && button15.Text == "0" && button19.Text == "0" && button20.Text == "0")
            {
                listBox1.Items.Add("(b.c)+");
            }
            if (button17.Text == "0" && button18.Text == "0" && button22.Text == "0" && button23.Text == "0")
            {
                listBox1.Items.Add("(a.c)+");
            }
            if (button18.Text == "0" && button19.Text == "0" && button23.Text == "0" && button24.Text == "0")
            {
                listBox1.Items.Add("(a.d)+");
            }
            if (button19.Text == "0" && button20.Text == "0" && button24.Text == "0" && button25.Text == "0")
            {
                listBox1.Items.Add("(a.c)+");
            }
        }
    }
}
