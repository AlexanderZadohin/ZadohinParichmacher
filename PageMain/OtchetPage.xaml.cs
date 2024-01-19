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

namespace ZadohinParichmacher.PageMain
{
    /// <summary>
    /// Логика взаимодействия для OtchetPage.xaml
    /// </summary>
    public partial class OtchetPage : Page
    {
        public OtchetPage()
        {
            InitializeComponent();

            OtchetDG.ItemsSource = App.context.Accounting.ToList();
            ChooseEmployeeCmb.ItemsSource = App.context.Employee.ToList();
            ChooseEmployeeCmb.DisplayMemberPath = "Name";
            ChooseEmployeeCmb.SelectedValuePath = "id";
        }

        private void ChooseOtchetBtn_Click(object sender, RoutedEventArgs e)
        {
            int count;
            decimal summa;
            if(ChooseEmployeeCmb.Text == "")
            {
                OtchetDG.ItemsSource = App.context.Accounting.Where(a => a.DateIspol >= DTPickBegin.SelectedDate && a.DateIspol <= DTPickEnd.SelectedDate).ToList();
                summa = Convert.ToDecimal(App.context.Accounting.Where(a => a.DateIspol >= DTPickBegin.SelectedDate && a.DateIspol <= DTPickEnd.SelectedDate).Select(c => c.Amount).Sum());
                AllCostTb.Text = Convert.ToString(summa);
                count = App.context.Accounting.Where(a => a.DateIspol >= DTPickBegin.SelectedDate && a.DateIspol <= DTPickEnd.SelectedDate).Select(g => g.idEmployee).Count();
                AmountZapTb.Text = Convert.ToString(count);
            }
            if(ChooseEmployeeCmb.Text != "")
            {
                OtchetDG.ItemsSource = App.context.Accounting.Where(a => a.DateIspol >= DTPickBegin.SelectedDate && a.DateIspol <= DTPickEnd.SelectedDate && a.idEmployee == ChooseEmployeeCmb.SelectedIndex + 1).ToList();
                summa = Convert.ToDecimal(App.context.Accounting.Where(a => a.DateIspol >= DTPickBegin.SelectedDate && a.DateIspol <= DTPickEnd.SelectedDate && a.idEmployee == ChooseEmployeeCmb.SelectedIndex + 1).Select(c => c.Amount).Sum());
                AllCostTb.Text = Convert.ToString(summa);
                count = App.context.Accounting.Where(a => a.DateIspol >= DTPickBegin.SelectedDate && a.DateIspol <= DTPickEnd.SelectedDate && a.idEmployee == ChooseEmployeeCmb.SelectedIndex + 1).Select(g => g.idEmployee).Count();
                AmountZapTb.Text = Convert.ToString(count);
            }

        }
    }
}
