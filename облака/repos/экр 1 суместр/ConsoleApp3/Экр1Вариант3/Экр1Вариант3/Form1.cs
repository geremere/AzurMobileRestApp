using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrigonometryFunctionLib2;

namespace Экр1Вариант3
{
    public partial class Form1 : Form
    {
        double A_;
        double B_;
        double C_;
        double X_;
        string Name_;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] boxes = { textBox2, textBox3, textBox4, textBox5 };
            for (int i = 0; i < 4; i++)
            {
                boxes[i].Text = boxes[i].Text.Replace(".", ",");
            }
            try
            {              
                A_ = double.Parse(textBox2.Text);
                B_= double.Parse(textBox3.Text);
                C_= double.Parse(textBox4.Text);
                X_ = double.Parse(textBox5.Text);
                Name_ = textBox1.Text;
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
                return;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
                return;
            }

            switch (comboBox1.Text)
            {
                case "Синус":
                    {
                        Sinus();
                        break;
                    }
                case "Тангенс":
                    {
                        Tangents();
                        break;
                    }
            }
        }

        private void Tangents()
        {
            Tanget tan;
            try
            {
                tan = new Tanget(Name_, B_, A_, C_);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }

            try
            {
                label6.Text = $"{tan.ToString()}\n{tan[X_]}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
        }

        private void Sinus()
        {
            Sinus sin;
            try
            {
                sin = new Sinus(Name_, B_, A_, C_);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
            }

            try
            {
                label6.Text = $"{sin.ToString()}\n{sin[X_]}";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
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
