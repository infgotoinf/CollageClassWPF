using System.Diagnostics.Metrics;

namespace _02_WinForms_Beginning
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            label1.Text = $"UwUwni {counter}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            if (!string.IsNullOrEmpty(name))
            {
                MessageBox.Show($"Привет, {name}!");
                label2.Text = $"привет, {name}!";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя.");
            }
        }


        int clickCount = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            clickCount++;

            switch (clickCount % 4)
            {
                case 1:
                    this.BackColor = Color.Red;
                    break;
                case 2:
                    this.BackColor = Color.Green;
                    break;
                case 3:
                    this.BackColor = Color.Blue;
                    break;
                case 0:
                    this.BackColor = Color.White;
                    break;
            }

        }
    }
}
