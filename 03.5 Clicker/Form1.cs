namespace _03._5_Clicker
{
    public partial class Form1 : Form
    {
        private static string resourses_directory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Resources\\";
        private int timer_time = 60;
        private int click_count = 5;
        private Random rand = new Random();
        private string[] files = Directory.GetFiles(resourses_directory);

        public Form1()
        {
            InitializeComponent();
        }

        private bool countdown_started = false;
        private int countdown = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown_started)
            {
                countdown--;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!countdown_started)
            {
                countdown = timer_time;
                countdown_started = true;
                pictureBox1.BackgroundImage = Image.FromFile(files[rand.Next(files.Length)]);
            }

            if (countdown <= 0)
            {
                countdown_started = false;
            }

            int seconds = countdown % 60;
            label1.Text = countdown / 60 + ":" + (seconds < 10 ? "0" + seconds : seconds);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countdown -= click_count;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer_time = hScrollBar1.Value;
            int seconds = timer_time % 60;
            label3.Text = timer_time / 60 + ":" + (seconds < 10 ? "0" + seconds : seconds);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            click_count = hScrollBar2.Value;
            label4.Text = click_count + "";
        }
    }
}
