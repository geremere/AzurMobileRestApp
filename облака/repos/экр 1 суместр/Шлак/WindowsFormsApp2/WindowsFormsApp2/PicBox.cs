using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PicBox : Form
    {
        Point mousePos;
        public Graphics gr; //Графика
        public Bitmap mp; //Битмап
        public Pen pn; //Ручка
        public double angl1 = Math.PI / 2; //Угол поворота на 90 градусов
        public double ang1 = Math.PI / 4;  //Угол поворота на 45 градусов
        public double ang2 = Math.PI / 6;  //Угол поворота на 30 градусов
        public uint recursion_max_level = 1;

        /// <summary>
        /// Конструктор
        /// </summary>
        public PicBox()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.MouseWheel += new MouseEventHandler(this_MouseWheel);
        }

        /// <summary>
        /// Moving picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                //mousePos.X += dx;
                //mousePos.Y += dy
                pictureBox.Location = new Point(pictureBox.Location.X - pictureBox.Width/2 + dx, pictureBox.Location.Y - pictureBox.Height/2 + dy);
            }
        }

        /// <summary>
        /// ZOOM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    if (pictureBox.Width < 50)//min
                        return;
                }
                else
                {
                    if (pictureBox.Width > 1000)//max
                        return;
                }
                pictureBox.Width += Convert.ToInt32(pictureBox.Width * e.Delta / 1000);
                pictureBox.Height += Convert.ToInt32(pictureBox.Height * e.Delta / 1000);
            }
        }

        public void pictureBoxOne(object sender, EventArgs e)
        {
            //pictureBox.Size = this.Size;
            Piftree pt = new Piftree();
            pt.DrawingTree(pictureBox.Width/4, pictureBox.Height/3, 7, angl1, ref pictureBox);
            //pictureBox.Image = mp;


        }

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //  Piftree pt = new Piftree();
        //pt.DrawingTree(this.Width / 2, this.Height / 2, 7, angl1, ref pictureBox);
        //base.OnPaint(e);
        //}


    }
}
