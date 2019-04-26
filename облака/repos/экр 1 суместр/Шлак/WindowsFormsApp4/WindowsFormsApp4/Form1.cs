using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Graphics g; //Графика
        public Bitmap map; //Битмап
        public Pen p; //Ручка
        public int iter = 1; //Количество итераций


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);//Подключаем Битмап
            g = Graphics.FromImage(map); //Подключаем графику
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//Включаем сглаживание
            p = new Pen(Color.Green);  //Зеленая ручка
            g.Clear(Color.Black);      //Черный фон

            //Присваеваем размеры picturebox в отдельные переменные, для простоты обращения
            int h = pictureBox1.Height;
            int w = pictureBox1.Width;

            //Выберем начальные точки
            PointF A = new PointF(w * 3 / 4, h * 3 / 4);
            PointF B = new PointF(w / 4, h * 3 / 4);
            PointF C = new PointF(w / 2, h / 4);


            //Рисуем изначальный треугольник
            g.DrawLine(p, A.X, A.Y, B.X, B.Y);
            g.DrawLine(p, B.X, B.Y, C.X, C.Y);
            g.DrawLine(p, A.X, A.Y, C.X, C.Y);


            //Вызываем рекурсивную функцию отрисовки фрактала
            drawMCTriangle(A, B, C, iter);

            //Переносим изображение из битмапа на picturebox
            pictureBox1.BackgroundImage = map;

        }

        //Рекурсивная функция отрисовки фрактала
        public int drawMCTriangle(PointF A, PointF B, PointF C, int iter)
        {
            //Параметры: точки А В С начального треугольника и кол-во итераций iter

            //База рекурсии
            if (iter == 0) //если итераций 0 - то выход
                return 0;

            PointF D = new PointF();    //Точка центра масс
            PointF v1 = new PointF();   //Вектор AB
            PointF v2 = new PointF();   //Вектор AC

            //Вектор АB
            v1.X = B.X - A.X;
            v1.Y = B.Y - A.Y;

            //Вектор AC
            v2.X = C.X - A.X;
            v2.Y = C.Y - A.Y;

            D.X = A.X + (v1.X + v2.X) / 3;     //К точке А прибавим сумму векторов AВ и AC, деленную на 3
            D.Y = A.Y + (v1.Y + v2.Y) / 3;     //и получим координаты центра масс

            g.DrawLine(p, A.X, A.Y, D.X, D.Y);    //Рисуем отрезки от вершин к центру масс
            g.DrawLine(p, B.X, B.Y, D.X, D.Y);
            g.DrawLine(p, C.X, C.Y, D.X, D.Y);

            drawMCTriangle(A, B, D, iter - 1);    //Вызываем рекурсивно процендуру для полученных 
            drawMCTriangle(B, C, D, iter - 1);    //треугольников, с итерацией, меньшей на 1
            drawMCTriangle(A, C, D, iter - 1);

            return 0;

        }
    }
}