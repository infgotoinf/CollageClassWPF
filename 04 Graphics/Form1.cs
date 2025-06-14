using NAudio;
using NAudio.Wave;

namespace _04_Graphics
{
    public partial class Form1 : Form
    {
        private WaveStream stream1;
        private WaveStream stream2;
        private WaveOut out1;
        private WaveOut out2;
        private string project_directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

        private float angle = 1;
        private float angle_prev = 1;
        private float speedup;
        private float multiplier = 1.05F;
        private int counter;
        private bool spin = false;
        int spin_end = 0;

        private const float number_of_numbers = 36.9f;
        private const float number_step = 360f / number_of_numbers;
        private int[] numbers = {0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13,
                               36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14,
                               31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26};
        private int[] redNumbers = {32, 19, 21, 25, 34, 27, 36, 30, 23, 5, 16, 1, 14, 9, 18, 7, 12, 3};
        private int old_number = 0;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            stream1 = new AudioFileReader(project_directory + "\\Resources\\808-HiHats23.wav");
            out1 = new();
            out1.Init(stream1);
            stream2 = new AudioFileReader(project_directory + "\\Resources\\Melo'ed-808.wav");
            out2 = new();
            out2.Init(stream2);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            try
            {
                Image wheel = Image.FromFile(project_directory + "\\Resources\\13315-Photoroom.png");
                Image ball = Image.FromFile(project_directory + "\\Resources\\ball.png");
                // Перемещаем начало координат
                g.TranslateTransform(ClientSize.Width / 2, ClientSize.Height / 2);
                g.RotateTransform(angle);

                // Рисуем изображение
                g.DrawImage(wheel, -250, -250, 500, 500);
                g.RotateTransform(angle);
                g.DrawImage(ball, -10, -97, 15, 15);
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
            if (!spin)
            {
                spin = true;
                Random rnd = new();
                spin_end = rnd.Next(37);
                counter = 0;
                speedup = 1.1F;
            }
        }

        private int actual_number;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!spin)
            {
                angle += 0.5f;
            }
            else
            {
                angle += speedup;
                counter++;
                if (counter < 75 + spin_end)
                {
                    speedup *= multiplier;
                }
                else
                {
                    speedup /= multiplier;
                }
                if (angle == angle_prev)
                {
                    spin = false;
                    stream2.CurrentTime = new TimeSpan(0L);
                    out2.Play();

                    label3.Text = actual_number < 10 ? " " + actual_number + " " : actual_number.ToString();
                    if (redNumbers.Contains(actual_number))
                        label3.BackColor = Color.Red;
                    else if (actual_number == 0)
                        label3.BackColor = Color.Green;
                    else label3.BackColor = Color.Black;
                }
                else
                {
                    angle_prev = angle;
                }
            }
            angle %= 360;
            actual_number = numbers[(int)(angle / number_step)];

            label1.Text = angle.ToString() + " " + actual_number;

            label2.Text = actual_number < 10 ? " "+actual_number+" " : actual_number.ToString();
            if (redNumbers.Contains(actual_number))
                label2.BackColor = Color.Red;
            else if (actual_number == 0)
                label2.BackColor = Color.Green;
            else label2.BackColor = Color.Black;

            this.Invalidate();
            if (old_number != actual_number)
            {
                if (out1.PlaybackState is PlaybackState.Playing) out1.Stop();
                stream1.CurrentTime = new TimeSpan(0L);
                out1.Play();

                old_number = actual_number;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
