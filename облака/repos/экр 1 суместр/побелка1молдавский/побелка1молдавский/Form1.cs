using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace побелка1молдавский
{
    public partial class Form1 : Form
    {
        string Name_;
        double Increase_;
        double TaxRate_;
        int Tenure_;
        int Cost_;
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
                Increase_ = double.Parse(textBox2.Text);
                TaxRate_ = double.Parse(textBox3.Text);
                Tenure_ = int.Parse(textBox4.Text);
                Cost_ = int.Parse(textBox5.Text);
            }
            catch(ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Exception");
                return;
            }

            switch(comboBox1.Text)
            {
                case ("Apartment"):
                    {
                        Apartmt();
                        break;
                    }
                case ("CountryHouse"):
                    {
                        CountryHouse_();
                        break;
                    }

            }
        }

        private void CountryHouse_()
        {
            CountryHouse countryhouse;
            try
            {
                countryhouse = new CountryHouse(Name_, Increase_, TaxRate_, Tenure_);
            }
            catch (FunctionLibException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
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
                label6.Text = countryhouse.ToString() + $"Налог равен: {countryhouse[Cost_]:f3}";
            }
            catch (FunctionLibException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
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

        private void Apartmt()
        {
            Apartment apartment;
            try
            {
                apartment = new Apartment(Name_, Increase_, TaxRate_, Tenure_);
            }
            catch (FunctionLibException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
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
                label6.Text = apartment.ToString() + $"Налог равен: {apartment[Cost_]:f3}";
            }
            catch (FunctionLibException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                return;
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
