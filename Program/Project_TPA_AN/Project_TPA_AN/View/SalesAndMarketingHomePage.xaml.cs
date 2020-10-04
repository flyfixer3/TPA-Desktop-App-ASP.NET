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
    /// Interaction logic for SalesAndMarketingHomePage.xaml
    /// </summary>
    public partial class SalesAndMarketingHomePage : Page
    {
        public SalesAndMarketingHomePage()
        {
            InitializeComponent();
        }

        private void ManageAdvertisement_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ManageAllAdsPage());
        }

        private void FundRequest_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FundRequestPage());
        }

        private void PurchaseRequest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
