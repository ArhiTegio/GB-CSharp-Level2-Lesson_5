using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_CSharp_Level2_Lesson_5
{
    public class Department
    {
        string name = "";
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        ObservableCollection<Job> planingJob = new ObservableCollection<Job>();
        Dictionary<Job, Employee> jobInWork = new Dictionary<Job, Employee>();
        Dictionary<Job, Employee> jobIsDone = new Dictionary<Job, Employee>();
        double profit = 0;

        public Department(string name, double profit)
        {
            Name = name;
            Profit = profit;
        }

        public string Name { get => name; set => name = value; }
        public double Profit { get => profit; set => profit = value; }
        internal ObservableCollection<Employee> Employees { get => employees; set => employees = value; }
        internal ObservableCollection<Job> PlaningJob { get => planingJob; set => planingJob = value; }
        internal Dictionary<Job, Employee> JobInWork { get => jobInWork; set => jobInWork = value; }
        internal Dictionary<Job, Employee> JobIsDone { get => jobIsDone; set => jobIsDone = value; }

        public override string ToString() => $" {Name} Прибыль: {Profit}";
    }
}
