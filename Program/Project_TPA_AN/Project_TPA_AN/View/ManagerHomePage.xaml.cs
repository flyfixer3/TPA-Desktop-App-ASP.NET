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

namespace Project_TPA_AN.View
{
    /// <summary>
    /// Interaction logic for ManagerHomePage.xaml
    /// </summary>
    public partial class ManagerHomePage : Page
    {
        public ManagerHomePage()
        {
            InitializeComponent();
        }

        private void ShowRideAttracRequest_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ViewAllRideAtttracionRequestPage());
        }

        private void showEmployee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void showIncreaseSalaryReq_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sendFiringReq_Click(object sender, RoutedEventArgs e)
        {

        }

        private void showFund_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SendResignation_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sendLeavingPermit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackToLogin(object sender, RoutedEventArgs e)
        {

        }

        private void salaryRequest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
