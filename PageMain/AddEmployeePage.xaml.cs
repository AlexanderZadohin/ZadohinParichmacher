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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZadohinParichmacher.Model;

namespace ZadohinParichmacher.PageMain
{
    /// <summary>
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (EmployeeNameTB.Text == "")
            {
                mes = "Введите имя сотрудника";
                MessageBox.Show(mes);
                return;
            }
            else
            {
                Employee addEmployee = new Employee
                {
                    Name = EmployeeNameTB.Text
                };
                App.context.Employee.Add(addEmployee);
                App.context.SaveChanges();
                MessageBox.Show("Сотрудник добавлен!");
                EmployeeNameTB.Text = "";
            }
        }
    }
}
