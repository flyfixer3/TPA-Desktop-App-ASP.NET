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
    /// Interaction logic for ManageAllAdsPage.xaml
    /// </summary>
    public partial class ManageAllAdsPage : Page
    {
        public ManageAllAdsPage()
        {
            InitializeComponent();
            refreshTable();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            Advertisement rslt = AdvertisementController.SearchByID(id);
            if (rslt != null)
            {
                advertisementDescriptionText.Text = rslt.AdvertisementDescription;
                AdsDeadline.SelectedDate = rslt.Deadline;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Advertisement newAds = new Advertisement();
            newAds.AdvertisementID = Int32.Parse(idText.Text);
            newAds.Deadline = AdsDeadline.SelectedDate.Value;
            newAds.AdvertisementDescription = advertisementDescriptionText.Text;
            AdvertisementController.DeleteAds(newAds);
            refreshTable();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Advertisement newAds = new Advertisement();
            newAds.AdvertisementID = Int32.Parse(idText.Text);
            newAds.Deadline = AdsDeadline.SelectedDate.Value;
            newAds.AdvertisementDescription = advertisementDescriptionText.Text;
            newAds.AdvertisementStatus = "Active";
            newAds.EmployeeID = ActiveUserController.GetActiveEmployee().EmployeeID;
            AdvertisementController.UpdateAds(newAds);
            refreshTable();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Advertisement newAds = new Advertisement();
            newAds.EmployeeID = ActiveUserController.GetActiveEmployee().EmployeeID;
            newAds.Deadline = AdsDeadline.SelectedDate.Value;
            newAds.AdvertisementDescription = advertisementDescriptionText.Text;
            AdvertisementController.CreateAdvertisement(newAds);
            refreshTable();
        }

        private void refreshTable()
        {
            var data = (from x in DatabaseSingleton.GetInstance().Advertisements.Where(x =>x.AdvertisementStatus != "Deleted")
                        select new {
                            AdvertisementID = x.AdvertisementID,
                            AdvertisementDescription = x.AdvertisementDescription,
                            AdvertisementDeadline = x.Deadline,
                            EmployeeID = x.EmployeeID
                        }).ToList();
            adsTable.ItemsSource = data;
        }
    }
}
