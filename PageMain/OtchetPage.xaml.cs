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
    }
}
