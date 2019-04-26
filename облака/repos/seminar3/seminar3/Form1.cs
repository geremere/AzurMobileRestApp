using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Random rnd = new Random();
            InitializeComponent();
            this.MouseClick += (e,e1) =>
            {
                BackColor = Color.Red;
            };

            this.MouseEnter += (e, e1) =>
            {
                BackColor = Color.White;
            };
            this.MouseDoubleClick += (e, e1) =>
            {
                this.Size = new Size(rnd.Next(100,1000),rnd.Next(100,1000));
            };

        }
    }
}
