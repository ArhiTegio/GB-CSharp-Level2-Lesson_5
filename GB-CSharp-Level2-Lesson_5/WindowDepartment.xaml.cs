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
    /// Логика взаимодействия для WindowDepartment.xaml
    /// </summary>
    public partial class WindowDepartment : Window
    {
        Department department;
        Company company;
        ListView listView;

        public WindowDepartment(Department department, Company company, ListView listView)
        {
            this.company = company;
            this.department = department;
            InitializeComponent();
            dep_Name.Text = department.Name;
            dep_Profit.Text = department.Profit.ToString();
            dep_Name.KeyUp += delegate 
            {
                department.Name = dep_Name.Text;
                listView.ItemsSource = company.Departments;
                listView.Items.Refresh();
            };
            dep_Profit.KeyUp += delegate 
            {
                department.Profit = Convert.ToInt32(dep_Profit.Text);
                listView.Items.Refresh();
            };
            dep_Profit.KeyDown += new KeyEventHandler(NumericTextBox_KeyDown);
        }

        private void NumericTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Char.IsDigit((char)KeyInterop.VirtualKeyFromKey(e.Key)) &&
                e.Key != Key.Back || e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
