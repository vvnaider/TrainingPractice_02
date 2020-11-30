using System;
using System.Drawing;
using System.Windows.Forms;


namespace WinEquation
{
    public partial class FormMy : Form
    {

        public FormMy()
        {
            InitializeComponent();
        }

        private void DrawBackGround()
        {
            int sizeX = panelEquation.Size.Width;
            int sizeY = panelEquation.Size.Height;
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;

            minX = Convert.ToDouble(textBoxMinX.Text);
            maxX = Convert.ToDouble(textBoxMaxX.Text);
            minY = Convert.ToDouble(textBoxMinY.Text);
            maxY = Convert.ToDouble(textBoxMaxY.Text);

            Graphics g = panelEquation.CreateGraphics();
            g.Clear(Color.Black);

            for (int i = 0; i < sizeX; i += 20) //координатная сетка, оси координат, подписи к осям
            {
                g.DrawLine(new Pen(Color.DarkSlateGray), new Point(i, 0), new Point(i, sizeY));
            }
            for (int i = 0; i < sizeY; i += 20)
            {
                g.DrawLine(new Pen(Color.DarkSlateGray), new Point(0, i), new Point(sizeX, i));
            }
            g.DrawLine(new Pen(Color.DarkGray), new Point(0, sizeY / 2), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.DarkGray, 2), new Point(sizeX - 10, sizeY / 2 - 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.DarkGray, 2), new Point(sizeX - 10, sizeY / 2 + 10), new Point(sizeX, sizeY / 2));
            g.DrawLine(new Pen(Color.DarkGray), new Point(sizeX / 2, 0), new Point(sizeX / 2, sizeY));
            g.DrawLine(new Pen(Color.DarkGray, 2), new Point(sizeX / 2 - 10, 0 + 10), new Point(sizeX / 2, 0));
            g.DrawLine(new Pen(Color.DarkGray, 2), new Point(sizeX / 2 + 10, 0 + 10), new Point(sizeX / 2, 0));

            for (int i = 40; i < sizeX; i += 40)
            {
                if (i == sizeX / 2) continue; // засечки по горизонтали
                string st = (minX + i * ((maxX - minX) / sizeX)).ToString();
                g.DrawLine(new Pen(Color.DarkGray, 2), new Point(i, sizeY / 2 + 5), new Point(i, sizeY / 2 - 5));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.DarkGray), new PointF(i - 15, sizeY / 2 + 4));
            }
            for (int i = 40; i < sizeY; i += 40)
            {
                if (i == sizeY / 2) continue; // засечки по вертикали
                string st = (minX + (sizeY - i) * ((maxY - minY) / sizeY)).ToString();
                g.DrawLine(new Pen(Color.DarkGray, 2), new Point(sizeX / 2 + 5, i), new Point(sizeX / 2 - 5, i));
                g.DrawString(st, new Font("Arial", 8), new SolidBrush(Color.DarkGray), new PointF(sizeX / 2 - 15, i + 4));
            }
            string point = "(" + (minX + (maxX - minX) / 2) + "; " + (minX + (maxY - minY) / 2) + ")";
            g.DrawString(point, new Font("Arial", 8), new SolidBrush(Color.DarkGray), new PointF(sizeX / 2 - 15, sizeY / 2 + 4));
        }

        private void DrawEquation(string equation, Color equationColor)
        {
            int sizeX = panelEquation.Size.Width;
            int sizeY = panelEquation.Size.Height;
            double minX = -10, maxX = 10;
            double minY = -10, maxY = 10;

            minX = Convert.ToDouble(textBoxMinX.Text);
            maxX = Convert.ToDouble(textBoxMaxX.Text);
            minY = Convert.ToDouble(textBoxMinY.Text);
            maxY = Convert.ToDouble(textBoxMaxY.Text);

            SyntaxTree calculator = new SyntaxTree(equation);

            Graphics g = panelEquation.CreateGraphics();

            Point currentPoint = new Point();
            Point previousPoint = new Point();
            bool isCurentPoint = false;
            bool isPreviousPoint = false;
            for (double x = minX; x < maxX; x += (maxX - minX) / sizeX)
            {
                double y = calculator.Calculate(x, out isCurentPoint);
                if (Math.Abs(y) > maxY * 2) isCurentPoint = false;
                if (isCurentPoint)
                {
                    currentPoint.X = (int)(x / ((maxX - minX) / sizeX) - minX / ((maxX - minX) / (double)sizeX));
                    currentPoint.Y = (int)(sizeY - (y / ((maxY - minY) / sizeY) - minY / ((maxY - minY) / (double)sizeY)));
                    if (isPreviousPoint)
                    {
                        g.DrawLine(new Pen(equationColor, 2), previousPoint, currentPoint);
                    }
                }
                previousPoint = currentPoint;
                isPreviousPoint = isCurentPoint;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e) // кнопка "Добавить" (Add)
        {
            EquationColor fc = new EquationColor("", Color.Black);
            FormEquation formEquation = new FormEquation(fc);
            if (formEquation.ShowDialog() == DialogResult.OK)
            {
                listBoxEquation.Items.Add(fc);
                DrawEquation(fc.Equation, fc.Color);
            }           
        }

        private void buttonEdit_Click(object sender, EventArgs e)  // кнопка "Изменить уравнение" (Edit)
        {
            if (listBoxEquation.SelectedItem == null) return;
            FormEquation formEquation = new FormEquation(listBoxEquation.SelectedItem as EquationColor);
            
            if (formEquation.ShowDialog() == DialogResult.OK)
            {
                listBoxEquation.Items.Remove(listBoxEquation.SelectedItem);
                listBoxEquation.Items.Add(formEquation.Fc);

                DrawBackGround();
                for (int i = 0; i < listBoxEquation.Items.Count; i++)
                {
                    EquationColor fc = listBoxEquation.Items[i] as EquationColor;
                    DrawEquation(fc.Equation, fc.Color);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) // кнопка "Удалить" (Delete)
        {
            if (listBoxEquation.SelectedItem == null) return;

            listBoxEquation.Items.Remove(listBoxEquation.SelectedItem);

            DrawBackGround();
            for (int i = 0; i < listBoxEquation.Items.Count; i++)
            {
                EquationColor fc = listBoxEquation.Items[i] as EquationColor;
                DrawEquation(fc.Equation, fc.Color);
            }
        }
 

        private void panelEquation_Paint(object sender, PaintEventArgs e)
        {
            DrawBackGround();
        }

        private void buttonRefresh_Click(object sender, EventArgs e) // кнопка "Обновить"
        {
            DrawBackGround();
            for(int i = 0; i < listBoxEquation.Items.Count; i++)
            {
                EquationColor fc = listBoxEquation.Items[i] as EquationColor;
                DrawEquation(fc.Equation, fc.Color);
            }
        }

        private void FormMy_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxDiapason_Enter(object sender, EventArgs e)
        {

        }
    }
}
