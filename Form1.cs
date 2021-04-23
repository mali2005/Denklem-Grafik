using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static float Eval(String expression)
        {

            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToSingle(table.Compute(expression, String.Empty));
        }
        Graphics g;
        Random r = new Random();
        Pen pen = new Pen(Color.FromArgb(255, 255, 255));
        private void button1_Click(object sender, EventArgs e)
        {
            if (denklem != "")
            {
                listBox1.Items.Clear();
                try
                {
                    if (denklem.IndexOf("^") == -1)
                    {
                        string a;
                        float y;
                        int eskiy;
                        for (float i = -200; i < 200; i++)
                        {

                            a = denklem.Replace("x", i.ToString());
                            y = Eval(a);
                            g.DrawLine(pen, new Point(Convert.ToInt32(200 + i - 1), Convert.ToInt32(200 - Eval(denklem.Replace("x", (i - 1).ToString())))), new Point(Convert.ToInt32(i + 200), Convert.ToInt32(200 - y)));
                            listBox1.Items.Add("X = " + i.ToString() + " Y = " + y.ToString());
                        }
                    }
                    else if (denklem.IndexOf("^3") != -1)
                    {
                        string a;
                        float y, y2;

                        for (float i = -200; i < 200; i++)
                        {
                            a = denklem.Replace("x^3", Math.Pow(i, 3).ToString());
                            a = a.Replace("x^2", Math.Pow(i, 2).ToString());
                            a = a.Replace("x", i.ToString());
                            y = Eval(a);
                            a = denklem.Replace("x^3", Math.Pow(i-1, 3).ToString());
                            a = a.Replace("x^2", Math.Pow(i - 1, 2).ToString());
                            a = a.Replace("x", (i - 1).ToString());
                            y2 = Eval(a);
                            g.DrawLine(pen, new Point(Convert.ToInt32(200 + i - 1), Convert.ToInt32(200 - y2)), new Point(Convert.ToInt32(200 + i), Convert.ToInt32(200 - y)));
                            listBox1.Items.Add("X = " + i.ToString() + " Y = " + y.ToString());
                        }
                    }
                    else if (denklem.IndexOf("^2") != -1)
                    {
                        string a;
                        float y, y2;

                        for (float i = -200; i < 200; i++)
                        {
                            a = denklem.Replace("x^2", Math.Pow(i, 2).ToString());
                            a = a.Replace("x", i.ToString());
                            y = Eval(a);
                            a = denklem.Replace("x^2", Math.Pow(i - 1, 2).ToString());
                            a = a.Replace("x", (i - 1).ToString());
                            y2 = Eval(a);
                            g.DrawLine(pen, new Point(Convert.ToInt32(200 + i - 1), Convert.ToInt32(200 - y2)), new Point(Convert.ToInt32(200 + i), Convert.ToInt32(200 - y)));
                            listBox1.Items.Add("X = " + i.ToString() + " Y = " + y.ToString());
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ne yazık ki hesaplayamıyoruz. Bir yerde yanlışlık mı yaptınız ?\n \n +Profesyoneller İçin Hata Çıktısının Birazı:\n\n" + ex.ToString().Substring(0, ex.ToString().Length - 10), "Hesaplanamadı?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Denklem Girin!!");
            }


        }
        string denklem = "";
        private void button21_Click(object sender, EventArgs e)
        {
            denklem += "(";
            textBox1.Text = denklem;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            denklem += ")";
            textBox1.Text = denklem;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            denklem += "1";
            textBox1.Text = denklem;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            denklem += "2";
            textBox1.Text = denklem;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            denklem += "3";
            textBox1.Text = denklem;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            denklem += "4";
            textBox1.Text = denklem;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            denklem += "5";
            textBox1.Text = denklem;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            denklem += "6";
            textBox1.Text = denklem;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            denklem += "7";
            textBox1.Text = denklem;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            denklem += "8";
            textBox1.Text = denklem;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            denklem += "9";
            textBox1.Text = denklem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denklem += "x";
            textBox1.Text = denklem;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            denklem += "0";
            textBox1.Text = denklem;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            denklem += ".";
            textBox1.Text = denklem;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            denklem += "-";
            textBox1.Text = denklem;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            denklem += "+";
            textBox1.Text = denklem;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            denklem += "*";
            textBox1.Text = denklem;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            denklem += "/";
            textBox1.Text = denklem;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            denklem = "";
            textBox1.Text = denklem;
            g.Clear(Color.Black);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (denklem != "")
            {
                denklem = denklem.Remove(denklem.Length - 1, 1);
            }

            textBox1.Text = denklem;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
            g.Clear(Color.Black);
            panel2.BackColor = Color.FromArgb(2, 2, 2);
            panel3.BackColor = Color.FromArgb(2, 2, 2);
            this.TransparencyKey = Color.FromArgb(2, 2, 2);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            denklem += "x^2";
            textBox1.Text = denklem;
        }
        int x,y;
        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            x = -(this.Location.X - Cursor.Position.X);
            y = Cursor.Position.Y - this.Location.Y;
            hareket.Start();
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            hareket.Stop();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            denklem += "x^3";
            textBox1.Text = denklem;
        }

        private void hareket_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
        }
    }
}
