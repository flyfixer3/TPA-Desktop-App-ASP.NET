using Project_TPA_AN.Controller;
using Project_TPA_AN.View.Request;
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

namespace Project_TPA_AN.View
{
    /// <summary>
    /// Interaction logic for CreativeHomePage.xaml
    /// </summary>
    public partial class CreativeHomePage : Page
    {
        public CreativeHomePage()
        {
            InitializeComponent();
        }

        private void ManageAllAttraction(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ManageAllAttractionPage());
        }

        private void ManageAllRide(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ManageAllRidePage());
        }

        private void PurchaseRequest(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PurchaseRequestPage());
        }

        private void FundRequest(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FundRequestPage());
        }

        private void ViewManagerResponse(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ViewManagerResponse());
        }

        private void LeavingPermission(object sender, RoutedEventArgs e)
        {

        }

        private void DoResignLetter(object sender, RoutedEventArgs e)
        {

        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            ActiveUserController.SetActiveEmployee(null);
            this.NavigationService.Navigate(new LoginPage());
        }
    }
}
