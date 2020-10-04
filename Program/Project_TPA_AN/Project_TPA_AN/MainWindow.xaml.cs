using Project_TPA_AN.View;
using Project_TPA_AN.View.Ride_Request;
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

namespace Project_TPA_AN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeFrame();
        }

        public void InitializeFrame()
        {
            //MainFrame.NavigationService.Navigate(new CreativeHomePage());
            //MainFrame.NavigationService.Navigate(new ManagerHomePage());
            //MainFrame.NavigationService.Navigate(new ConstructionHomePage());
            MainFrame.NavigationService.Navigate(new LoginPage());
        }

    }
}
