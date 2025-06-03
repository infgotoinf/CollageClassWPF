using System.Threading.Tasks;
using _02._5_WinForms_Beggining2;

namespace _02._5_WinForms_Beggining2
{

    public partial class Form1 : Form
    {
        List<Task> tasks = new List<Task>();

        void updateByPriority()
        {
            List<Task> tasks1 = new List<Task>();
            List<Task> tasks2 = new List<Task>();
            List<Task> tasks3 = new List<Task>();

            foreach (Task task in tasks)
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
            List<Task> tasks = new List<Task>();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {}

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {}

        private void label1_Click(object sender, EventArgs e)
        {}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            List<Task> tasks1 = new List<Task>();
            List<Task> tasks2 = new List<Task>();
            List<Task> tasks3 = new List<Task>();

            foreach ( Task task in tasks )
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
            List<Task> tasks = new List<Task>();
            tasks.Add()
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

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

    }
}
