using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppetest1
{
    public partial class Form1 : Form
    {
        public Graphics gr; //Графика
        public Bitmap mp; //Битмап
        public Pen pn; //Ручка
        public double ag1 = Math.PI / 2; //Угол поворота на 90 градусов
        public double ag2 = Math.PI / 4;  //Угол поворота на 45 градусов
        public double ag3 = Math.PI / 6;  //Угол поворота на 30 градусов
        
        public Form1()
        {
            InitializeComponent();
        }


        public void pictureBox4(object sender, EventArgs e)
        {
            PifagorsTree pt = new PifagorsTree();
            pt.CreatePT(300, 450, 5, ag1);
        }
    }


    public class PifagorsTree : Form1
    {
        public PifagorsTree()
        {
            mp = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            gr = Graphics.FromImage(mp); //Подключаем графику
            pn = new Pen(Color.Green);
        }

        public void CreatePT(double x, double y, double a, double ag1)
        {
            while (a != 0)
            {
                double xnew = Math.Round(x + a * Math.Cos(ag1)),
                           ynew = Math.Round(y - a * Math.Sin(ag1));

                //рисуем линию между вершинами
                gr.DrawLine(pn, (float)x, (float)y, (float)xnew, (float)ynew);

                //Переприсваеваем координаты
                x = xnew;
                y = ynew;
                a--;
                Console.WriteLine(a);
                pictureBox4.Image = mp;
                //Вызываем рекурсивную функцию для левого и правого ребенка
                CreatePT(x, y, a, ag1 + ag2);
                CreatePT(x, y, a, ag1 - ag3);
            }
        }
    }

}
