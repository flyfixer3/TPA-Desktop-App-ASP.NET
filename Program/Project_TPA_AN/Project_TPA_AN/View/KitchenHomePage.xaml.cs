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
    /// Interaction logic for KitchenHomePage.xaml
    /// </summary>
    public partial class KitchenHomePage : Page
    {
        public KitchenHomePage()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredient a = new Ingredient();
            a.IngredientID = Int32.Parse(idText.Text);
            a.IngredientName = NameText.Text;
            a.IngredientStock = Int32.Parse(QuantityText.Text);
            a.IngredientStatus = "Active";
            IngredientController.Delete(a);
            RefreshTable();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredient a = new Ingredient();
            a.IngredientID = Int32.Parse(idText.Text);
            a.IngredientName = NameText.Text;
            a.IngredientStock = Int32.Parse(QuantityText.Text);
            a.IngredientStatus = "Active";
            IngredientController.Update(a);
            RefreshTable();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredient a = new Ingredient();
            a.IngredientName = NameText.Text;
            a.IngredientStock = Int32.Parse(QuantityText.Text);
            a.IngredientStatus = "Active";
            IngredientController.addIngredient(a);
            RefreshTable();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            Ingredient a = IngredientController.SearchByID(id);
            NameText.Text = a.IngredientName;
            QuantityText.Text = a.IngredientStock.ToString();
        }
        private void RefreshTable()
        {
            IngredientTable.ItemsSource = DatabaseSingleton.GetInstance().Ingredients.Where(x=> x.IngredientStatus != "Deleted").ToList();
        }
        private void PurchaseButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PurchaseRequestPage());
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
