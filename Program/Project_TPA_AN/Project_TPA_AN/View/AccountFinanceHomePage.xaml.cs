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
    /// Interaction logic for AccountFinanceHomePage.xaml
    /// </summary>
    public partial class AccountFinanceHomePage : Page
    {
        public AccountFinanceHomePage()
        {
            InitializeComponent();
            AcceptButton.IsEnabled = false;
            RejectButton.IsEnabled = false;
            RefreshTable();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            FundRequest rslt = FundController.SearchByID(id);
            if (rslt != null)
            {
                NameLabel.Content = "Request " + rslt.FundId + "was Found !";
                AcceptButton.IsEnabled = true;
                RejectButton.IsEnabled = true;
            }
            else
            {
                NameLabel.Content = "Not found !";
                AcceptButton.IsEnabled = false;
                RejectButton.IsEnabled = false;
            }
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            FundController.AcceptingFundRequest(id);
            MessageBox.Show("Accept Fund Request !");
            RefreshTable();
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            FundController.RejectingFundRequest(id);
            MessageBox.Show("Reject Fund Request !");
            RefreshTable();
        }
        private void RefreshTable()
        {
            EventTable.ItemsSource = DatabaseSingleton.GetInstance().FundRequests.Where(x => x.FundStatus.Contains("Pending")).ToList();
        }
    }
}
