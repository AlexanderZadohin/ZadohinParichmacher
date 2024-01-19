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
using ZadohinParichmacher.Class;

namespace ZadohinParichmacher.PageMain
{
    /// <summary>
    /// Логика взаимодействия для MenuLeftPage.xaml
    /// </summary>
    public partial class MenuLeftPage : Page
    {
        public MenuLeftPage()
        {
            InitializeComponent();
        }

        private void AddManufacturerBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.AddManufacturerPage());
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrameBody.Navigate(new PageMain.AddProductPage());
        }

        private void AddEmployeeBtn_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrameBody.Navigate(new PageMain.AddEmployeePage());
        }

        private void VedenieUcetaBtn_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrameBody.Navigate(new PageMain.VedenieUcetaPage());
        }

        private void Otchet_Click(object sender, RoutedEventArgs e)
        {

            ClassFrame.FrameBody.Navigate(new PageMain.OtchetPage());
        }

        private void OtchetWithTimeBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.OtchetWithTime());
        }
    }
}
