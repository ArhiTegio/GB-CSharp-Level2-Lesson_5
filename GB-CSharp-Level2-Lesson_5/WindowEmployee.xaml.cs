using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GB_CSharp_Level2_Lesson_5
{
    /// <summary>
    /// Логика взаимодействия для WindowEmployee.xaml
    /// </summary>
    public partial class WindowEmployee : Window
    {
        BaseEmployee employee;
        Department department;
        string department_Name;
        Company company;
        ListView listView;

        public WindowEmployee(BaseEmployee employee, Department department, Company company, ListView listView)
        {
            InitializeComponent();
            this.employee = employee;
            this.department = department;
            this.company = company;
            this.listView = listView;
            dep.ItemsSource = company.Departments.Select(x => x.Name);
            dep.Text = department.Name;
            dep.SelectionChanged += delegate { Dep_SelectChanged(); };
            department_Name = department.Name;
            tb_Name.Text = employee.Name;
            tb_Age.Text = employee.Age.ToString();
            tb_Salary.Text = employee.Salary.ToString();
            tb_Name.KeyUp += new KeyEventHandler(tb_Name_KeyDown);
            tb_Age.KeyUp += new KeyEventHandler(tb_Age_KeyDown);
            tb_Salary.KeyUp += new KeyEventHandler(tb_Salery_KeyDown);
            tb_Name.KeyDown += new KeyEventHandler(LetterTextBox_KeyDown);
            tb_Age.KeyDown += new KeyEventHandler(NumericTextBox_KeyDown);
            tb_Salary.KeyDown += new KeyEventHandler(NumericTextBox_KeyDown);
        }

        private void Dep_SelectChanged()
        {
            company.Departments.Where(x => x.Name == department_Name).FirstOrDefault().Employees.Remove((Employee)employee);
            company.Departments.Where(x => x.Name == dep.Text).FirstOrDefault().Employees.Add((Employee)employee);
            department_Name = dep.Text;

        }

        private void NumericTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key)) && 
                e.Key != Key.Back || e.Key == Key.Space)
                e.Handled = true;
        }

        private void LetterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key)))
                e.Handled = true;
        }

        void tb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (tb_Name != null)
            {
                employee.Name = tb_Name.Text;
                listView.Items.Refresh();
            }

        }

        void tb_Age_KeyDown(object sender, KeyEventArgs e)
        {
            if (int.TryParse(tb_Age.Text, out var t))
            {
                employee.Age = t;
                listView.Items.Refresh();
            }
        }

        void tb_Salery_KeyDown(object sender, KeyEventArgs e)
        {
            if (int.TryParse(tb_Salary.Text, out var t))
            {
                employee.Salary = t;
                listView.Items.Refresh();
            }
        }
    }
}
