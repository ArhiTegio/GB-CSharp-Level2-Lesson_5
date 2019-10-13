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
        Company company;

        public WindowEmployee(BaseEmployee employee, Department department, Company company)
        {
            InitializeComponent();
            this.employee = employee;
            this.department = department;
            this.company = company;

            dep.ItemsSource = company.Departments.Select(x => x.Name);
            dep.Text = department.Name;
            tb_Name.Text = employee.Name;
            tb_Age.Text = employee.Age.ToString();
            tb_Salery.Text = employee.Salary.ToString();
            tb_Name.KeyUp += new KeyEventHandler(MainWindow_KeyDown1);
            tb_Age.KeyUp += new KeyEventHandler(MainWindow_KeyDown2);
            tb_Salery.KeyUp += new KeyEventHandler(MainWindow_KeyDown3);
        }

        void MainWindow_KeyDown1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Subtract)
            {
                // Do something
            }
        }

        void MainWindow_KeyDown2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Subtract)
            {
                // Do something
            }
        }

        void MainWindow_KeyDown3(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Subtract)
            {
                // Do something
            }
        }
    }
}
