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
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();

            ChooseManufacturerCmb.ItemsSource = App.context.Manufacturer.ToList();

            ChooseManufacturerCmb.DisplayMemberPath = "Name";

            ChooseManufacturerCmb.SelectedValuePath = "id";
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (ProductNameTB.Text == "")
                mes += "Введите наименование продукта\n";
            if (ChooseManufacturerCmb.Text == "")
                mes += "Выберите производителя\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                return;
            }
            else
            {
                Material addMaterial = new Material
                {
                    Name = ProductNameTB.Text,
                    Manufacturer = ChooseManufacturerCmb.SelectedItem as Manufacturer
                };

                App.context.Material.Add(addMaterial);
                App.context.SaveChanges();
                MessageBox.Show("Добавлен новый инструмент");
                ProductNameTB.Text = "";
                ChooseManufacturerCmb.Text = "";
            }
        }
    }
}
