using System;
using System.Drawing;
using System.Windows.Forms;
namespace pr_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        Point click;
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            g.FillEllipse(Brushes.Green, 100, 100, 100, 100);
            g.DrawRectangle(new Pen(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }, 270, 100, 100, 100);
            g.DrawLine(Pens.Black, 450, 150, 550, 150);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
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
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    g.DrawEllipse(Pens.GreenYellow, 400, 400, 100, 100);
                    break;
                case Keys.B:
                    g.DrawRectangle(Pens.Aqua, 500, 500, 150, 150);
                    break;
                case Keys.Delete:
                    g.Clear(Color.White);
                    break;
            }
        }
    }
}