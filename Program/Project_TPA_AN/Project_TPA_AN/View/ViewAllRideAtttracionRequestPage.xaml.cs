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
    /// Interaction logic for ViewAllRideAtttracionRequestPage.xaml
    /// </summary>
    public partial class ViewAllRideAtttracionRequestPage : Page
    {
        public ViewAllRideAtttracionRequestPage()
        {
            InitializeComponent();
            AttractionRadioButton.IsChecked = true;
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            if (RideRadioButton.IsChecked == true)
            {
                if (RequestRideController.SearchByID(id).RideStatus_.Equals("Pending Add"))
                {
                    RequestRideController.AcceptRide(id, "Accepted For Adding");
                }
                else if (RequestRideController.SearchByID(id).RideStatus_.Equals("Pending Update"))
                {
                    RequestRideController.AcceptRide(id, "Accepted For Updating");
                }
                else
                {
                    RequestRideController.AcceptRide(id, "Accepted For Deleting");
                }
                refreshTableRide();
            }
            else
            {
                if (RequestAttractionController.SearchByID(id).AttractionStatus.Equals("Pending Add"))
                {
                    RequestAttractionController.AcceptAttraction(id, "Accepted For Adding");
                }
                else if (RequestAttractionController.SearchByID(id).AttractionStatus.Equals("Pending Update"))
                {
                    RequestAttractionController.AcceptAttraction(id, "Accepted For Updating");
                }
                else
                {
                    RequestAttractionController.AcceptAttraction(id, "Accepted For Deleting");
                }
                refreshTableAttraction();
            }
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            if (RideRadioButton.IsChecked == true)
            {
                if (RequestRideController.SearchByID(id).RideStatus_.Contains("Pending"))
                {
                    RequestRideController.RejectRide(id);
                    refreshTableRide();
                }
            }
            else
            {
                if (RequestAttractionController.SearchByID(id).AttractionStatus.Contains("Pending"))
                {
                    RequestAttractionController.RejectAttraction(id);
                    refreshTableAttraction();
                }
            }
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            if (AttractionRadioButton.IsChecked == true)
            {
                RequestAttraction rslt = RequestAttractionController.SearchByID(id);
                if (rslt != null)
                {
                    NameLabel.Content = "Request of " + rslt.AttractionName + "Attraction was " + rslt.AttractionStatus;
                    if (rslt.AttractionStatus.Contains("Pending"))
                    {
                        AcceptButton.IsEnabled = true;
                        RejectButton.IsEnabled = true;
                    }
                }
                else
                {
                    NameLabel.Content = "Not found !";
                }
            }
            else
            {
                RequestRide rslt = RequestRideController.SearchByID(id);
                if (rslt != null)
                {
                    NameLabel.Content = "Your Request " + rslt.RideName + "Ride was " + rslt.RideStatus_;
                    if (rslt.RideStatus_.Contains("Accepted"))
                    {
                        AcceptButton.IsEnabled = true;
                        RejectButton.IsEnabled = true;
                    }
                }
                else
                {
                    NameLabel.Content = "Not found !";
                }
            }

        }

        private void refreshTableRide()
        {
            var requestRideDetails = DatabaseSingleton.GetInstance().RequestRides.Where(x => x.RideStatus_.Contains("Pending")).ToList();
            EventTable.ItemsSource = requestRideDetails;

        }
        private void refreshTableAttraction()
        {
            var requestAttractionDetails = DatabaseSingleton.GetInstance().RequestAttractions.Where(x => x.AttractionStatus.Contains("Pending")).ToList();
            EventTable.ItemsSource = requestAttractionDetails;
        }

        private void RideRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            refreshTableRide();
        }

        private void AttractionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            refreshTableAttraction();
        }
    }
}
