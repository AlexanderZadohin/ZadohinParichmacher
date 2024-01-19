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
    /// Логика взаимодействия для VedenieUcetaPage.xaml
    /// </summary>
    public partial class VedenieUcetaPage : Page
    {
        public VedenieUcetaPage()
        {
            InitializeComponent();

            ChooseEmployeeCmb.ItemsSource = App.context.Employee.ToList();
            ChooseEmployeeCmb.DisplayMemberPath = "Name";
            ChooseEmployeeCmb.SelectedValuePath = "id"; 

            ChooseManufacturerCmb.ItemsSource = App.context.Manufacturer.ToList();
            ChooseManufacturerCmb.DisplayMemberPath = "Name";
            ChooseManufacturerCmb.SelectedValuePath = "id";

            ChooseMaterialCmb.ItemsSource = App.context.Material.ToList();
            ChooseMaterialCmb.DisplayMemberPath = "Name";
            ChooseMaterialCmb.SelectedValuePath = "id";

            
        }

        private void AddUcetBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (ChooseDTPicker.Text == "")
                mes += "Выберите дату!\n";
            if (ChooseEmployeeCmb.Text == "")
                mes += "Выберите сотрудника!\n";
            if (ChooseManufacturerCmb.Text == "")
                mes += "Выберите производителя\n";
            if (ChooseMaterialCmb.Text == "")
                mes += "Выберите инструмент!\n";
            if (AmountTB.Text == "")
                mes += "Впишите количество!\n";
            if (CostTB.Text == "")
                mes += "Впишите цену!\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                return;
            }
            else
            {
                Accounting addAccounting = new Accounting
                {
                    DateIspol = Convert.ToDateTime(ChooseDTPicker.Text),
                    Employee = ChooseEmployeeCmb.SelectedItem as Employee,
                    Material = ChooseMaterialCmb.SelectedItem as Material,
                    Price = Convert.ToDecimal(CostTB.Text),
                    Quantity = Convert.ToInt32(AmountTB.Text)
                };

                App.context.Accounting.Add(addAccounting);
                App.context.SaveChanges();
                MessageBox.Show("Учет добавлен!");
                ChooseEmployeeCmb.Text = "";
                ChooseManufacturerCmb.Text = "";
                ChooseMaterialCmb.Text = "";
                ChooseDTPicker.Text = "";
                AmountTB.Text = "";
                CostTB.Text = "";
            }

        }

        private void ChooseManufacturerCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedManufacturer = Convert.ToInt32(ChooseManufacturerCmb.SelectedValue);
            ChooseMaterialCmb.ItemsSource = App.context.Material.Where(m => m.Manufacturer.id == SelectedManufacturer).ToList();
        }
    }
}
