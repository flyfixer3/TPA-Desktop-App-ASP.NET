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
    /// Interaction logic for HRDHomePage.xaml
    /// </summary>
    public partial class HRDHomePage : Page
    {
        public HRDHomePage()
        {
            InitializeComponent();
        }

        private void DoViewAllEmployeeData(object sender, RoutedEventArgs e)
        {

        }

        private void DoRequestGrowthSalary(object sender, RoutedEventArgs e)
        {

        }

        private void DoSendFundRequest(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FundRequestPage());
        }

        private void DoCreateFiringReason(object sender, RoutedEventArgs e)
        {

        }

        private void DoViewAllEmployeeRequestForLeaving(object sender, RoutedEventArgs e)
        {

        }

        private void DoRegisterEmployee(object sender, RoutedEventArgs e)
        {

        }

        private void DoLeavingPermission(object sender, RoutedEventArgs e)
        {

        }

        private void DoResignLetter(object sender, RoutedEventArgs e)
        {

        }

        private void DoLogout(object sender, RoutedEventArgs e)
        {

        }
    }
}
