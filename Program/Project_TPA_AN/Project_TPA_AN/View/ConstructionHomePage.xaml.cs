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
    /// Interaction logic for ConstructionHomePage.xaml
    /// </summary>
    public partial class ConstructionHomePage : Page
    {
        public ConstructionHomePage()
        {
            InitializeComponent();
            viewAllRide.IsChecked = true;
            startConstructionButton.IsEnabled = false;
            finishConstruct.IsEnabled = false;
        }

        private void FinishConstruct_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            Ride rslt = RideController.SearchByID(id);
            if (rslt.RideStatus_.Contains("In Progress To Delete"))
            {
                RideController.FinishDeleteRide(rslt);
            }
            else if (rslt.RideStatus_.Contains("In Progress To Add"))
            {
                RideController.FinishAddRide(rslt);
            }
            else if (rslt.RideStatus_.Contains("In Progress To Update"))
            {
                RideController.FinishUpdateRide(rslt);
            }

            refreshTable();
        }

        private void StartConstructionButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            Ride rslt = RideController.SearchByID(id);
            if (rslt.RideStatus_.Contains("Waiting For Construction To Delete"))
            {
                RideController.ProgressDelete(rslt);
            }else if (rslt.RideStatus_.Contains("Waiting For Construction To Add"))
            {
                RideController.ProgressAdd(rslt);
            }else if (rslt.RideStatus_.Contains("Waiting For Construction To Update"))
            {
                RideController.ProgressUpdate(rslt);
            }
            refreshTable();
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            Ride rslt = RideController.SearchByID(id);
            if (rslt != null)
            {
                NameLabel.Content = "Your Status of " + rslt.RideName + "Ride was " + rslt.RideStatus_;
                if (rslt.RideStatus_.Contains("Waiting For Construction"))
                {
                    startConstructionButton.IsEnabled = true;
                    finishConstruct.IsEnabled = false;
                }
                else if(rslt.RideStatus_.Contains("In Progress"))
                {                    
                    finishConstruct.IsEnabled = true;
                }
            }
            else
            {
                NameLabel.Content = "Not found !";
                finishConstruct.IsEnabled = false;
                startConstructionButton.IsEnabled = false;
            }
        }

        private void ViewRidePlan_Checked(object sender, RoutedEventArgs e)
        {
            var planRideDetails = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideStatus_.Contains("Waiting") || x.RideStatus_.Contains("In Progress")).ToList();
            EventTable.ItemsSource = planRideDetails;
        }

        private void ViewAllRide_Checked(object sender, RoutedEventArgs e)
        {
            var rideDetails = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideStatus_.Equals("Actived")).ToList();
            EventTable.ItemsSource = rideDetails;
        }

        private void refreshTable()
        {
            var planRideDetails = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideStatus_.Contains("Waiting") || x.RideStatus_.Contains("In Progress")).ToList();
            EventTable.ItemsSource = planRideDetails;
            var rideDetails = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideStatus_.Equals("Actived")).ToList();
            EventTable.ItemsSource = rideDetails;
        }
        private void FundRequestButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FundRequestPage());
        }

        private void PurchaseRequestButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PurchaseRequestPage());
        }
    }
}
