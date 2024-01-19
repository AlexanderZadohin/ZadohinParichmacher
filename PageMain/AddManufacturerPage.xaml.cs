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
    /// Логика взаимодействия для AddManufacturerPage.xaml
    /// </summary>
    public partial class AddManufacturerPage : Page
    {
        public AddManufacturerPage()
        {
            InitializeComponent();
        }

        private void AddManufacturerBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (ManufacturerTB.Text == "")
            {
                mes = "Введите имя сотрудника";
                MessageBox.Show(mes);
                return;
            }
            else
            {
                Manufacturer addManufacturer = new Manufacturer
                {
                    Name = ManufacturerTB.Text
                };
                App.context.Manufacturer.Add(addManufacturer);
                App.context.SaveChanges();
                MessageBox.Show("Добавлен производитель!");
                ManufacturerTB.Text = "";
            }
        }
    }
}
