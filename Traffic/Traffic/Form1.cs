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

namespace Traffic
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush br;
        Pen p;
        GraphicsPath path1;
        GraphicsPath path2;
        GraphicsPath path3;
        
        
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            p = new Pen(Color.Black, 3);
            br = new SolidBrush(Color.Black);
            path1 = new GraphicsPath();
            path2 = new GraphicsPath();
            path3 = new GraphicsPath();
            timer1.Interval = 1800;
            timer1.Enabled = true;
            timer2.Interval = 1900;
            timer2.Enabled = true;
            timer3.Interval = 2100;
            timer3.Enabled = true;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawRectangle(p, 100, 100, 50, 100);
            g.DrawLine(p, 126, 200, 126, 260);
            path1.Reset();
            path2.Reset();
            path3.Reset();
            path1.AddEllipse(111, 111, 26, 26);
            path2.AddEllipse(111, 140, 26, 26);
            path3.AddEllipse(111, 169, 26, 26);
            p = new Pen(Color.Yellow);
            g.DrawPath(p, path2);
            p = new Pen(Color.Red, 3);
            g.DrawPath(p, path1);
            p = new Pen(Color.Green, 3);
            g.DrawPath(p, path3);



        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location + " ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            br = new SolidBrush(Color.Red);
            g.FillEllipse(br, 111, 111, 26, 26);
            br = new SolidBrush(Color.White);
            g.FillEllipse(br, 111, 140, 26, 26);
            g.FillEllipse(br, 111, 169, 26, 26);


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            br = new SolidBrush(Color.Yellow);
            g.FillEllipse(br, 111, 140, 26, 26);
            br = new SolidBrush(Color.White);
            g.FillEllipse(br, 111, 111, 26, 26);
            g.FillEllipse(br, 111, 169, 26, 26);
           



        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
            br = new SolidBrush(Color.Green);
            g.FillEllipse(br, 111, 169, 26, 26);
            br = new SolidBrush(Color.White);
            g.FillEllipse(br, 111, 111, 26, 26);
            g.FillEllipse(br, 111, 140, 26, 26);



        }
        


        }
    }

