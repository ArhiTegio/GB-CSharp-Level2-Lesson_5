using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_CSharp_Level2_Lesson_5
{
    public class Company
    {
        private ObservableCollection<Department> departments = new ObservableCollection<Department>();
        double costs = 0.0;
        double profit = 0.0;

        public double Costs { get => costs; set => costs = value; }
        public double Profit { get => profit; set => profit = value; }
        internal ObservableCollection<Department> Departments { get => departments; set => departments = value; }
    }
}
