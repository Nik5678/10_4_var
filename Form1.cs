using System.Drawing.Drawing2D;

namespace _10_4_вариант
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Size = new Size(800, 600);
            this.Text = "Рисование фигур";
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Pen solidPen = new Pen(Color.Red, 3);
            Pen dashPen = new Pen(Color.Blue, 3) { DashStyle = DashStyle.Dash };
            Pen dotPen = new Pen(Color.Green, 3) { DashStyle = DashStyle.Dot };

            SolidBrush blueBrush = new SolidBrush(Color.CornflowerBlue);
            SolidBrush yellowBrush = new SolidBrush(Color.Gold);

            g.DrawLine(solidPen, 50, 50, 250, 50);
            g.DrawLine(dashPen, 50, 100, 250, 100);
            g.DrawLine(dotPen, 50, 150, 250, 150);

            g.DrawRectangle(solidPen, new Rectangle(300, 50, 150, 100));
            g.FillRectangle(blueBrush, new Rectangle(300, 200, 150, 100));

            g.DrawEllipse(dashPen, new Rectangle(500, 50, 150, 100));
            g.FillEllipse(yellowBrush, new Rectangle(500, 200, 150, 100));

            Point[] polygonPoints = {
                new Point(100, 400),
                new Point(200, 350),
                new Point(300, 400),
                new Point(250, 500),
                new Point(150, 500)
            };
            g.DrawPolygon(dotPen, polygonPoints);
            g.FillPolygon(blueBrush, polygonPoints);

            solidPen.Dispose();
            dashPen.Dispose();
            dotPen.Dispose();
            blueBrush.Dispose();
            yellowBrush.Dispose();
        }
    }
}
