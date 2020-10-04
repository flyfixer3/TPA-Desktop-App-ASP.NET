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
    /// Interaction logic for ViewManagerResponse.xaml
    /// </summary>
    public partial class ViewManagerResponse : Page
    {
        public ViewManagerResponse()
        {
            InitializeComponent();
            RideRadioButton.IsChecked = true;
            executeButton.IsEnabled = false;
        }


        private void RideRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var requestRideDetails = DatabaseSingleton.GetInstance().RequestRides.ToList();
            EventTable.ItemsSource = requestRideDetails;
        }

        private void AttractionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var requestAttractionDetails = DatabaseSingleton.GetInstance().RequestAttractions.ToList();
            EventTable.ItemsSource = requestAttractionDetails;
        }
        private void Search(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            if(AttractionRadioButton.IsChecked == true)
            {
                RequestAttraction rslt = RequestAttractionController.SearchByID(id);
                if (rslt != null)
                {
                    NameLabel.Content = "Your Request " + rslt.AttractionName + "Attraction was "+ rslt.AttractionStatus;
                    if (rslt.AttractionStatus.Equals("Accepted"))
                    {
                        executeButton.IsEnabled = true;
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
                    NameLabel.Content = "Your Request " + rslt.RideName +"Ride was "+rslt.RideStatus_;
                    if (rslt.RideStatus_.Contains("Accepted"))
                    {
                        executeButton.IsEnabled = true;
                    }
                }
                else
                {
                    NameLabel.Content = "Not found !";
                }
            }
            
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            if (RideRadioButton.IsChecked == true)
            {
                if (RequestRideController.SearchByID(id).RideStatus_.Equals("Accepted For Adding"))
                {
                    RideController.CreateRide(RequestRideController.SearchByID(id));
                }
                else if (RequestRideController.SearchByID(id).RideStatus_.Equals("Accepted For Updating"))
                {
                    RideController.UpdateRide(RequestRideController.SearchByID(id));
                }
                else
                {
                    RideController.deleteRide(RequestRideController.SearchByID(id));
                }
                RequestRideController.FinishRequestRide(id);
            }
            else
            {
                if(RequestAttractionController.SearchByID(id).AttractionStatus.Equals("Accepted For Adding"))
                {
                    AttractionController.CreateRide(RequestAttractionController.SearchByID(id));
                }else if(RequestAttractionController.SearchByID(id).AttractionStatus.Equals("Accepted For Updating"))
                {
                    AttractionController.UpdateAttraction(RequestAttractionController.SearchByID(id));
                }
                else
                {
                    AttractionController.deleteAttraction(RequestAttractionController.SearchByID(id));
                }
                
                RequestAttractionController.FinishRequestAttraction(id);
            }
        }
    }
}
