using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyLib;

namespace экрв1вариант2
{
    public partial class Form1 : Form
    {
        string Name_;
        double Increase_;
        double TaxRate_;
        int Cost_;
        int Tenure_;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Name_ = textBox1.Text;
                Increase_ = double.Parse(textBox2.Text);
                textBox4.Text = textBox4.Text.Replace(".", ",");
                TaxRate_ = double.Parse(textBox4.Text);
                Tenure_ = int.Parse(textBox3.Text);
                Cost_ = int.Parse(textBox5.Text);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Exception");
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


            if (comboBox1.Text=="Apartment")
            {
                Apartment apartment;
                try
                {
                    apartment = new Apartment(Name_, Increase_, TaxRate_, Tenure_);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
                    return;
                }
                catch (OverflowException ex)
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
                    label6.Text = apartment.ToString() + Environment.NewLine + $"{apartment[Cost_]:f3}";
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
            if (comboBox1.Text == "CountryHouse")
            {
                CountryHouse countryhouse;
                try
                {
                    countryhouse = new CountryHouse(Name_, Increase_, TaxRate_, Tenure_);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Exception");
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
                try
                {
                    label6.Text = countryhouse.ToString() + Environment.NewLine + $"{countryhouse[Cost_]:F3}";
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
}
