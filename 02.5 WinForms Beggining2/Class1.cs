using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._5_WinForms_Beggining2
{
    class Task
    {
        public string name {  get; set; }
        public string priority { get; set; }
        public DateTime date { get; set; }

        public Task(string name, string priority)
        {
            this.name = name;
            this.priority = priority;
            this.date = DateTime.Now;
        }

        public string GetTask()
        {
            return this.name + " " + this.priority + " " + this.date;
        }
    }
}
