using System;
using System.Drawing;
using System.Windows.Forms;
namespace pr_1
{
    public partial class Form1 : Form
    {
        private Point click;
        private Graphics g;
        private bool drawEllipse = true;
        private bool drawRectangle = true;

        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (drawRectangle)
                            g.FillRectangle(Brushes.Yellow, 500, 300, 300, 150);
                        break;
                    case Keys.B:
                        if (drawEllipse)
                            g.FillEllipse(Brushes.Blue, 600, 100, 150, 150);
                        break;
                    case Keys.Delete:
                        if (drawEllipse)
                            g.FillEllipse(Brushes.White, 600, 100, 150, 150);
                        if (drawRectangle)
                            g.FillRectangle(Brushes.White, 500, 300, 300, 150);
                        break;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            if (drawEllipse)
                g.FillEllipse(Brushes.Green, 100, 100, 100, 100);
            if (drawRectangle)
            {
                g.DrawRectangle(new Pen(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, 270, 100, 100, 100);
                g.DrawLine(Pens.Black, 450, 150, 550, 150);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            if (drawRectangle)
                g.DrawRectangle(Pens.Violet, click.X, click.Y, 180, 100);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            Point point1 = new Point(200, 350);
            Point point2 = new Point(200, 450);
            Point point3 = new Point(250, 400);
            Point point4 = new Point(300, 400);
            Point point5 = new Point(350, 250);
            Point point6 = new Point(200, 300);
            Point[] points = {
                point1, point2, point3, point4, point5, point6
            };
            Pen pen = new Pen(Color.Orange, 10);
            g.DrawPolygon(pen, points);
        }
    }
}