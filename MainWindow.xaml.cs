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

namespace ZadohinParichmacher
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ClassFrame.FrameMenu = MenuPage;
            MenuPage.Navigate(new PageMain.MenuLeftPage());

            ClassFrame.FrameBody = MainPage;
            MainPage.Navigate(new PageMain.BeginMainPage());
        }
    }
}
