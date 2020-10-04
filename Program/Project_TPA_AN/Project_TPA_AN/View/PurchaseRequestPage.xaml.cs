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
    /// Interaction logic for PurchaseRequestPage.xaml
    /// </summary>
    public partial class PurchaseRequestPage : Page
    {
        public PurchaseRequestPage()
        {
            InitializeComponent();
        }

        private void AddPurchaseRequest_Click(object sender, RoutedEventArgs e)
        {
            PurchaseRequest purchaseRequest = new PurchaseRequest();
            purchaseRequest.PurchaseDescription = purchaseDescTextt.Text;
            purchaseRequest.PurchaseRequestedDate = purchaseRequestedDate.SelectedDate.Value;
            purchaseRequest.DepartmentID = ActiveUserController.GetActiveEmployee().DepartmentID;
            PurchaseRequestController.CreatePurchaseRequest(purchaseRequest);
            MessageBox.Show("Succesfully Sent Request !");
        }
    }
}
