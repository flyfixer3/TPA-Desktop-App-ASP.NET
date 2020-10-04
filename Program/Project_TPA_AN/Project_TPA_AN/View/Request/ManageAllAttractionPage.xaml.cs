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

namespace Project_TPA_AN.View.Request
{
    /// <summary>
    /// Interaction logic for ManageAllAttractionPage.xaml
    /// </summary>
    public partial class ManageAllAttractionPage : Page
    {
        public ManageAllAttractionPage()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void searchAttraction(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            Attraction rslt = AttractionController.SearchByID(id);
            if (rslt != null)
            {
                attractionNameText.Text = rslt.AttractionName;
                AttractionDescriptionText.Text = rslt.AttractionDescription;
                attractionHowToWorkText.Text = rslt.AttractionHowToWork;
                AttractionParticipantsText.Text = rslt.AttractionParticipant;
                AttractionStartDate.Text = rslt.AttractionStartDate.ToString();
            }
        }

        private void deleteAttraction(object sender, RoutedEventArgs e)
        {
            RequestAttraction attraction = new RequestAttraction();
            attraction.AttractionID = Int32.Parse(idText.Text);
            attraction.AttractionName = attractionNameText.Text;
            attraction.AttractionStartDate = AttractionStartDate.SelectedDate.Value.Date;
            attraction.AttractionDescription = AttractionDescriptionText.Text;
            attraction.AttractionHowToWork = attractionHowToWorkText.Text;
            attraction.AttractionParticipant = AttractionParticipantsText.Text;
            attraction.AttractionStatus = "Pending Delete";
            RequestAttractionController.CreateRequestAttraction(attraction);
        }

        private void updateAttraction(object sender, RoutedEventArgs e)
        {
            RequestAttraction attraction = new RequestAttraction();
            attraction.AttractionID = Int32.Parse(idText.Text);
            attraction.AttractionName = attractionNameText.Text;
            attraction.AttractionStartDate = AttractionStartDate.SelectedDate.Value.Date;
            attraction.AttractionDescription = AttractionDescriptionText.Text;
            attraction.AttractionHowToWork = attractionHowToWorkText.Text;
            attraction.AttractionParticipant = AttractionParticipantsText.Text;
            attraction.AttractionStatus = "Pending Update";
            RequestAttractionController.CreateRequestAttraction(attraction);
        }

        private void RequestAttraction(object sender, RoutedEventArgs e)
        {
            RequestAttraction attraction = new RequestAttraction();
            attraction.AttractionName = attractionNameText.Text;
            attraction.AttractionStartDate = AttractionStartDate.SelectedDate.Value.Date;
            attraction.AttractionDescription = AttractionDescriptionText.Text;
            attraction.AttractionHowToWork = attractionHowToWorkText.Text;
            attraction.AttractionParticipant = AttractionParticipantsText.Text;
            attraction.AttractionStatus = "Pending Add";
            RequestAttractionController.CreateRequestAttraction(attraction);
        }

        private void LoadTableData()
        {
            var attractionDetails = DatabaseSingleton.GetInstance().Attractions.ToList();
            attractionTable.ItemsSource = attractionDetails;
        }
    }
}
