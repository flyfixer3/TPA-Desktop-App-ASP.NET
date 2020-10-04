using Project_TPA_AN.Model;
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
    /// Interaction logic for PurchasementPage.xaml
    /// </summary>
    public partial class PurchasementPage : Page
    {
        public PurchasementPage()
        {
            InitializeComponent();
        }

        private void AddPurchasement_Click(object sender, RoutedEventArgs e)
        {
            PurchasementReport newReport = new PurchasementReport();
            newReport.BuyerName = purchasementBuyer.Text;
            newReport.PurchasementDate = purchasementDate.SelectedDate.Value;
            newReport.PurchasePrice = Int32.Parse(purchasementPrice.Text);
            MessageBox.Show("Purchasement Report Added !");
            this.NavigationService.Navigate(new PurchasingHomePage());
        }
    }
}
