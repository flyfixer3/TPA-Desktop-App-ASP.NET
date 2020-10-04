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
    /// Interaction logic for FundRequestPage.xaml
    /// </summary>
    public partial class FundRequestPage : Page
    {
        public FundRequestPage()
        {
            InitializeComponent();
        }

        private void AddFundRequest_Click(object sender, RoutedEventArgs e)
        {
            FundRequest newFund = new FundRequest();
            newFund.FundPrice = Int32.Parse(fundPriceText.Text);
            newFund.FundReason = FundReasonText.Text;
            newFund.FundRequestedDate = fundRequestedDate.SelectedDate.Value;
            newFund.DepartmentID = ActiveUserController.GetActiveEmployee().DepartmentID;
            FundController.CreateFundRequest(newFund);
            MessageBox.Show("Succesfully Sent Request !");
        }

        private void ReasonText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
