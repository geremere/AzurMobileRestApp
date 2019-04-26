using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportLib;

namespace экр1варинат4
{
    public partial class Form1 : Form
    {
        string Name_;
        int FuelTank_;
        double FuelMilege_;
        double Miles_;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] boxes = { textBox2, textBox3 };
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].Text = boxes[i].Text.Replace(".", ",");
            }
            try
            {
                Name_ = textBox1.Text;
                FuelMilege_ = double.Parse(textBox2.Text);
                Miles_ = double.Parse(textBox3.Text);
                FuelTank_ = int.Parse(textBox4.Text);
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }
            switch (comboBox1.Text)
            {
                case ("Car"):
                    {
                        Car();
                        break;
                    }
                case ("Motorcycle"):
                    {
                        Motocycle();
                        break;
                    }
            }
        }

        private void Motocycle()
        {
            Motorcycle motorcycle;
            try
            {
                motorcycle = new Motorcycle(Name_, FuelTank_, FuelMilege_, Miles_);
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
                label5.Text = $"{motorcycle.ToString()}\n Колчество дозаправок, для того чтобы проехать {Miles_}км: {motorcycle[Miles_]}";
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

        private void Car()
        {
            Car car;
            try
            {
                car = new Car(Name_, FuelTank_, FuelMilege_, Miles_);
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
                label5.Text = $"{car.ToString()}\n Колчество дозаправок, для того чтобы проехать {Miles_}км: {car[Miles_]}";
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
