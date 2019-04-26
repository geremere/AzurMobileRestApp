using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double A;
        private double B;
        private int C;
        private int X;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inspect();
            Property pr;
            try
            {
                pr = new Apartment(A, B, C);
            }
            catch (PropertyExceptinon ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }

            textBox5.Clear();
            try
            {
                textBox5.Text = $"{pr.ToString()}" + Environment.NewLine +
                    $"{pr[X]:f3}";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }



        }

        private void Inspect()
        {
            try
            {
                A = double.Parse(textBox2.Text);
                B = double.Parse(textBox3.Text);
                C = int.Parse(textBox4.Text);
                X = int.Parse(textBox1.Text);

            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message, "exception");
                return;
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "exception");
                return;
            }
            catch (OverflowException e)
            {
                MessageBox.Show(e.Message, "exception");
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "exception");
                return;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inspect();
            Property ch;
            try
            {
                ch = new CountreeHouse(A, B, C);
            }
            catch (PropertyExceptinon ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }

            textBox5.Clear();
            try
            {
                textBox5.Text = $"{ch.ToString()}" + Environment.NewLine +
                    $"{ch[X]:f3}";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "exception");
                return;
            }

        }
    }
}
