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
    class Piftree : PicBox
    {
        public Piftree()
        {
            mp = new Bitmap(pictureBox.Width, pictureBox.Height);
            gr = Graphics.FromImage(mp);
            pn = new Pen(Color.Black);
            gr.Clear(Color.Red);
        }

        public Bitmap DrawingTree(double x, double y, double a, double ang, ref PictureBox nPictureBox)
        {
            if (a != 0)
            {
                double x1 = Math.Round(x + (a * Math.Cos(ang))*5),
                           y1 = Math.Round(y - (a * Math.Sin(ang))*5);

               
                gr.DrawLine(pn, (float)x, (float)y, (float)x1, (float)y1);
                x = x1;
                y = y1;
                a--;

                nPictureBox.Image = mp;
                nPictureBox.Refresh();

                DrawingTree(x, y, a, ang + ang1, ref nPictureBox);
                DrawingTree(x, y, a, ang - ang2, ref nPictureBox);
            }
            return mp;
        }
    }
}
