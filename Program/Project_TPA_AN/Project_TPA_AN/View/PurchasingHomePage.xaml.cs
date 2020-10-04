using Project_TPA_AN.Controller;
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
    /// Interaction logic for PurchasingHomePage.xaml
    /// </summary>
    public partial class PurchasingHomePage : Page
    {
        public PurchasingHomePage()
        {
            InitializeComponent();
            PurchasingRequestRadioButton.IsChecked = true;
            RejectButton.IsEnabled = false;
            AcceptButton.IsEnabled = false;
        }

        private void RequestFund_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            PurchaseRequestController.WaitingFundRequest(id);
            refreshTablePurchasing();
            MessageBox.Show("Redirect to fund request");
            this.NavigationService.Navigate(new FundRequestPage());

        }

        private void Search(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            PurchaseRequest purchaseRequest = PurchaseRequestController.SearchByID(id);
            if(purchaseRequest.PurchaseStatus.Equals("Waiting For Fund"))
            {
                AcceptButton.IsEnabled = true;
                RejectButton.IsEnabled = false;
            }
            else
            {
                RejectButton.IsEnabled = true;
                AcceptButton.IsEnabled = false;
            }
            NameLabel.Content = purchaseRequest.PurchaseID;
        }

        private void refreshTablePurchasing()
        {
            var data = DatabaseSingleton.GetInstance().PurchaseRequests.ToList();
            EventTable.ItemsSource = data;
        }
        private void refreshTableResponse()
        {
            var data = DatabaseSingleton.GetInstance().FundRequests.ToList();
            EventTable.ItemsSource = data;
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            PurchaseRequest purchaseRequest = PurchaseRequestController.SearchByID(id);
            PurchaseRequestController.RejectingPurchaseRequest(purchaseRequest);
            refreshTablePurchasing();
        }

        private void PurchasingRequestButton_Checked(object sender, RoutedEventArgs e)
        {
            searchButton.IsEnabled = true;
            RejectButton.IsEnabled = true;
            AcceptButton.IsEnabled = true;
            RequestFund.IsEnabled = true;
            refreshTablePurchasing();
        }

        private void FundResponseRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            searchButton.IsEnabled = false;
            RejectButton.IsEnabled = false;
            AcceptButton.IsEnabled = false;
            RequestFund.IsEnabled = false;
            refreshTableResponse();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            PurchaseRequest purchaseRequest = PurchaseRequestController.SearchByID(id);
            PurchaseRequestController.AcceptingPurchaseRequest(purchaseRequest);
            refreshTablePurchasing();
            this.NavigationService.Navigate(new PurchasementPage());
        }
    }
}
