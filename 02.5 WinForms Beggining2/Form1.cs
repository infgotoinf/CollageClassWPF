using System.Threading.Tasks;
using _02._5_WinForms_Beggining2;

namespace _02._5_WinForms_Beggining2
{

    public partial class Form1 : Form
    {
        List<Task> tasks = new List<Task>();


        void UpdateList()
        {
            if (radioButton1.Checked == true)
            {
                List<Task> tasks1 = new List<Task>();
                List<Task> tasks2 = new List<Task>();
                List<Task> tasks3 = new List<Task>();

                foreach (Task task in this.tasks)
                {
                    if (task.priority == "High")
                    {
                        tasks1.Add(task);
                    }
                    else if (task.priority == "Medium")
                    {
                        tasks2.Add(task);
                    }
                    else
                    {
                        tasks3.Add(task);
                    }
                }
                listBox1.Items.Clear();
                this.tasks.Clear();
                List<Task> tasks = new List<Task>();
                this.tasks.AddRange(tasks1);
                this.tasks.AddRange(tasks2);
                this.tasks.AddRange(tasks3);

                foreach (Task task in this.tasks)
                {
                    listBox1.Items.Add(task.GetTask());
                }
            }
            else if (radioButton2.Checked == true)
            {
                List<Task> tasks1 = new List<Task>();
                for (int j = 0; j < this.tasks.Count - 1; j++)
                {
                    for (int i = j; i < this.tasks.Count - 1; i++)
                    {
                        tasks1.Clear();
                        tasks1.AddRange(this.tasks);
                        if (tasks1[i].date > tasks1[i + 1].date)
                        {
                            tasks[i] = tasks1[i + 1];
                            tasks[i + 1] = tasks1[i];
                        }
                    }
                }
                listBox1.Items.Clear();
                foreach (Task task in this.tasks)
                {
                    listBox1.Items.Add(task.GetTask());
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            string userInput = textBox1.Text;

            if (selected == null || userInput == null)
                MessageBox.Show($"Input error!");
            else
            {
                if ((selected == "High" ||
                    selected == "Medium" ||
                    selected == "Low") &&
                    !(userInput == ""))
                {
                    Task task = new Task(userInput, selected);

                    tasks.Add(task);
                    listBox1.Items.Add(task.GetTask());
                }
                else
                {
                    MessageBox.Show($"Input error!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(0, 0);
        }
    }
}
