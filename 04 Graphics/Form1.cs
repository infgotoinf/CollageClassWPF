using System.Drawing.Drawing2D;

namespace _04_Graphics
{
    public partial class Form1 : Form
    {
        private float angle = 1;
        private float speedup = 1.1F;
        private float multiplier = 1.05F;
        private int counter = 0;
        private bool spin = false;

        private const int number_of_numbers = 36;
        private const int number_step = 360 / number_of_numbers;
        private int[] numbers = {0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13,
                               36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14,
                               31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26}; 
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            try
            {
                var project_directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                Image wheel = Image.FromFile(project_directory + "\\Resources\\13315-Photoroom.png");
                Image ball = Image.FromFile(project_directory + "\\Resources\\ball.png");

                // Перемещаем начало координат
                g.TranslateTransform(ClientSize.Width/2, ClientSize.Height/2);
                g.RotateTransform(angle); // Поворачиваем на 45 градусов

                // Рисуем изображение
                g.DrawImage(wheel, -250, -250, 500, 500);
                g.RotateTransform(-angle);
                g.DrawImage(ball, -10, -90, 15, 15);
                g.TranslateTransform(250, 250);

                // Восстанавливаем исходное состояние графики
                g.ResetTransform();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            spin = true;
        }

        private int actual_number;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!spin)
            {
                angle++;
            }
            else
            {
                angle += speedup;
                counter++;
                if (counter < 75)
                {
                    speedup *= multiplier;
                }
                else
                {
                    speedup /= multiplier;
                }
            }
            angle %= 361;
            actual_number = numbers[(int)(angle / number_step)];

            label1.Text = angle.ToString()+" "+ actual_number;
            this.Invalidate();
        }
    }
}
