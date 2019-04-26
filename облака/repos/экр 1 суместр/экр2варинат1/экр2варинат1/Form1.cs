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

namespace экр2варинат1
{
    public partial class Form1 : Form
    {
        int A;
        int B;
        int C;
        double X;
        string _Name;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checked();
            if(comboBox1.Text=="Hyperbola")
                FunctinHyperbola();
            if (comboBox1.Text == "Parabola")
                FunctionParabola();
        }

        private void Checked()
        {
            try
            {
                A = int.Parse(textBox1.Text);
                B = int.Parse(textBox2.Text);
                C = int.Parse(textBox3.Text);
                X = double.Parse(textBox4.Text);
                _Name = textBox5.Text;
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentNullException");
                return;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "FormatException");
                return;

            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
        }

        private void FunctionParabola()
        {
            Parabola parabola;
            try
            {
                parabola = new Parabola(_Name, A, B, C);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentException");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }

            try
            {
                textBox6.Text = parabola.ToString();
                textBox6.Text += Environment.NewLine + $"Значение функции в точке Х = {X}: {parabola[X]}";
            }           
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentException");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }

            try
            {
                textBox6.Text += Environment.NewLine + $"Площадь в интервале от {Math.Min(A,B)} до {Math.Max(A,B)}: {parabola[Math.Min(A, B), Math.Max(A, B)]}";
            }
            catch (FunctionLibArgumentException ex)
            {
                MessageBox.Show("end>start", "FunctionLibArgumentException");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentException");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
        }

        private void FunctinHyperbola()
        {
            Hyperbola hyperbola;
            try
            {
                hyperbola = new Hyperbola(_Name, A, B, C);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentException");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }

            try
            {
                textBox6.Text = hyperbola.ToString();
                textBox6.Text += Environment.NewLine +$"Значение функции в точке Х = {X}: {hyperbola[X]}";
            }
            catch (FunctionLibArgumentException ex)
            {
                MessageBox.Show("B*X+C=0 те деление на нуль", "FunctionLibArgumentException");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentException");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
            try
            {
                textBox6.Text += Environment.NewLine + $"Площадь в интервале от {Math.Min(A, B)} до {Math.Max(A, B)}: {hyperbola[Math.Min(A, B), Math.Max(A, B)]}";
            }
            catch (FunctionLibArgumentException ex)
            {
                MessageBox.Show("end>start", "FunctionLibArgumentException");
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ArgumentException");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "OverflowException");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
        }
    }
}
