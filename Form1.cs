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

            // Создание перьев с разными стилями
            Pen solidPen = new Pen(Color.Red, 3);
            Pen dashPen = new Pen(Color.Blue, 3) { DashStyle = DashStyle.Dash };
            Pen dotPen = new Pen(Color.Green, 3) { DashStyle = DashStyle.Dot };

            // Создание кистей
            SolidBrush blueBrush = new SolidBrush(Color.CornflowerBlue);
            SolidBrush yellowBrush = new SolidBrush(Color.Gold);

            // Рисование линий
            g.DrawLine(solidPen, 50, 50, 250, 50);      // Сплошная линия
            g.DrawLine(dashPen, 50, 100, 250, 100);     // Пунктирная линия
            g.DrawLine(dotPen, 50, 150, 250, 150);      // Точечная линия

            // Рисование прямоугольников
            g.DrawRectangle(solidPen, new Rectangle(300, 50, 150, 100));  // Незакрашенный
            g.FillRectangle(blueBrush, new Rectangle(300, 200, 150, 100)); // Закрашенный

            // Рисование эллипсов
            g.DrawEllipse(dashPen, new Rectangle(500, 50, 150, 100));      // Незакрашенный
            g.FillEllipse(yellowBrush, new Rectangle(500, 200, 150, 100)); // Закрашенный

            // Рисование многоугольника
            Point[] polygonPoints = {
                new Point(100, 400),
                new Point(200, 350),
                new Point(300, 400),
                new Point(250, 500),
                new Point(150, 500)
            };
            g.DrawPolygon(dotPen, polygonPoints);       // Незакрашенный
            g.FillPolygon(blueBrush, polygonPoints);     // Закрашенный

            // Освобождение ресурсов
            solidPen.Dispose();
            dashPen.Dispose();
            dotPen.Dispose();
            blueBrush.Dispose();
            yellowBrush.Dispose();
        }
    }
}
