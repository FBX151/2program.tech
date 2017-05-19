using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush b;
        Pen p;
        int r = 100;
        Point center,end,endm;
        GraphicsPath path;
        GraphicsPath path1;
        double deg;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            b = new SolidBrush(Color.Black);
            p = new Pen(Color.Black);
            
            center = new Point(200, 200);
            timer1.Interval = 1000;
            timer1.Enabled = true;
            deg = 270;
            end = new Point(200, 100);
            endm = new Point(200, 100);
            center = new Point(200, 200);
            path = new GraphicsPath();
            path1 = new GraphicsPath();
            timer2.Interval = 62000;
            timer2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            g.DrawEllipse(p, 100, 100, r*2, r*2);
            path.Reset();
            path1.Reset();
            path.AddLine(200, 200, end.X, end.Y);
            
            p = new Pen(Color.Red, 2);

            path1.AddLine(200, 200, endm.X, endm.Y);
            g.DrawPath(p, path);
            p = new Pen(Color.Black, 4);
            g.DrawPath(p, path1);
           

            
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location+" ");
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            double a = r * Math.Sin(deg * Math.PI / 180);
            double b = r * Math.Cos(deg * Math.PI / 180);
            end.X = center.X + (int)b;
            end.Y = center.Y + (int)a;
            deg += 6;
            if (deg == 360)
                deg = 0;
            Refresh();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            double a = r * Math.Sin(deg * Math.PI / 180);
            double b = r * Math.Cos(deg * Math.PI / 180);
            endm.X = center.X + (int)b;
            endm.Y = center.Y + (int)a;
            deg += 6;
            if (deg == 360)
                deg = 0;


            Refresh();
            

        }

    }
}
