using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionLib;

namespace ___ЭкрВ1
{
    public partial class Form1 : Form
    {
        double A;
        double B;
        double C;
        double X;
        string Name;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checked();

            Hyperbola hyperbola;
            try
            {
                hyperbola = new Hyperbola(Name, B, C, A);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Имя вводить только буквами латинского алфавита");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                textBox5.Text = hyperbola.ToString();
                textBox5.Text += Environment.NewLine + $"Значение функиции в точке Х = {X}: {hyperbola[X]}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }




        }

        private void Checked()
        {
            try
            {
                A = double.Parse(textBox1.Text);
                B = double.Parse(textBox2.Text);
                C = double.Parse(textBox3.Text);
                X = double.Parse(textBox4.Text);
                Name = textBox6.Text;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checked();

            Parabola parabola;
            try
            {
                parabola = new Parabola(Name, B, C, A);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Имя вводить только буквами латинского алфавита");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                textBox5.Text = parabola.ToString();
                textBox5.Text += Environment.NewLine + $"Значение функиции в точке Х = {X}: {parabola[X]}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
