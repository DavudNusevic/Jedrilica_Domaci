using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jedrilica_Domaci
{
    public partial class Form1 : Form
    {
        int X, Y, a, b;
        public Form1()
        {
            InitializeComponent();
            //timer1.Interval = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            X += 10;
            Refresh();

            if (X > ClientRectangle.Width + 2 * a)
                X = -2 * a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 40;
            X = -2 * a;
            Y = ClientRectangle.Height / 2;
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point p1 = new Point(X - 2*a, Y);
            Point p2 = new Point(X - 5 , Y);
            Point p3 = new Point(X - 5, Y - 3 * a);
            Point p4 = new Point(X + 5, Y - 3 * a);
            Point p5 = new Point(X + 2 * a, Y - 2 * a);
            Point p6 = new Point(X + 5, Y - a);
            Point p7 = new Point(X + 5, Y);
            Point p8 = new Point(X + 2 * a, Y);
            Point p9 = new Point(X + a, Y + a);
            Point p10 = new Point(X - a, Y + a);

            Graphics g = CreateGraphics();
            Pen olovka = new Pen(Color.Black, 1);
            SolidBrush cetka = new SolidBrush(Color.White);

            Point[] tacke = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };

            g.DrawPolygon(olovka, tacke);
            //g.FillPolygon(cetka, tacke);
        }
    }
}
