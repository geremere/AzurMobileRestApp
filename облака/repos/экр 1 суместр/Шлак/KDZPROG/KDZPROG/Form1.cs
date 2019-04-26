using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDZPROG
{
    public partial class Drow : Form
    {
        public Drow()
        { // конструктор формы
            InitializeComponent();
        }
        double step; // шаг изменения прозрачности изображения формы 
        private void Form1_Load(object sender, System.EventArgs e)
        {
            step = 0.1;
            timer1.Enabled = true;  // таймер включен
        }
        // Обработчик событий, инициированных тиками таймера:
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (step > 0)
            {
                string temp = label1.Text;
                if (temp.Length > 0)
                    label1.Text = temp.Substring(0, temp.Length - 1);
                else
                {
                    if (this.Opacity > 0)
                        this.Opacity = this.Opacity - step;
                    else
                    {
                        label1.Text = "Кот уже ушел!";
                        step = -step;
                    }
                }
            }
            else    // Здесь шаг отрицательный
                this.Opacity = this.Opacity - step;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}

