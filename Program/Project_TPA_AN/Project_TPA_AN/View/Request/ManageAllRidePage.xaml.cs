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

namespace Project_TPA_AN.View.Ride_Request
{
    /// <summary>
    /// Interaction logic for ManageAllRidePage.xaml
    /// </summary>
    public partial class ManageAllRidePage : Page
    {
        public ManageAllRidePage()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void RequestRide(object sender, RoutedEventArgs e)
        {
            RequestRide ride = new RequestRide();
            ride.RideName = rideNameText.Text;
            ride.RideType = rideType.Text;
            ride.RideDescription = rideDescriptionText.Text;
            ride.RideHowToWork = rideHowToWorkText.Text;
            ride.RideSafetyInformation = rideSafetyInformationText.Text;
            ride.RideStatus_ = "Pending Add";

            RequestRideController.CreateRequestRide(ride);
        }

        private void searchRide(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            Ride rslt = RideController.SearchByID(id);
            if(rslt != null)
            {
                rideNameText.Text = rslt.RideName;
                rideDescriptionText.Text = rslt.RideDescription;
                rideHowToWorkText.Text = rslt.RideHowToWork;
                rideSafetyInformationText.Text = rslt.RideSafetyInformation;
                rideType.Text = rslt.RideType;
            }
            
        }

        private void deleteRide(object sender, RoutedEventArgs e)
        {
            RequestRide ride = new RequestRide();
            ride.RideID = Int32.Parse(idText.Text);
            ride.RideName = rideNameText.Text;
            ride.RideType = rideType.Text;
            ride.RideDescription = rideDescriptionText.Text;
            ride.RideHowToWork = rideHowToWorkText.Text;
            ride.RideSafetyInformation = rideSafetyInformationText.Text;
            ride.RideStatus_ = "Pending Delete";
            RequestRideController.CreateRequestRide(ride);

        }

        private void updateRide(object sender, RoutedEventArgs e)
        {
            RequestRide ride = new RequestRide();
            ride.RideID = Int32.Parse(idText.Text);
            ride.RideName = rideNameText.Text;
            ride.RideType = rideType.Text;
            ride.RideDescription = rideDescriptionText.Text;
            ride.RideHowToWork = rideHowToWorkText.Text;
            ride.RideSafetyInformation = rideSafetyInformationText.Text;
            ride.RideStatus_ = "Pending Update";
            RequestRideController.CreateRequestRide(ride);
        }
        private void LoadTableData()
        {
            var rideDetails = DatabaseSingleton.GetInstance().Rides.ToList();
            rideTable.ItemsSource = rideDetails;
        }

        private void RideTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
