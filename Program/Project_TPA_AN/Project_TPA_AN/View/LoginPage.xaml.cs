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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void DoLoginButton(object sender, RoutedEventArgs e)
        {
            Employee employee = LoginController.DoUserLogin(usernameText.Text, passwordText.Password);

            if (employee == null)
            {
                errorLabelText.Text = "Invalid Credential";
                return;
            }   
            else
            {
                LoginController.DoFeedActiveEmployee(employee.EmployeeID);
                if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Manager"))
                {
                    ManagerHomePage managerHomePage = new ManagerHomePage();
                    this.NavigationService.Navigate(managerHomePage);
                }
                else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("HRD"))
                {
                    HRDHomePage hrdHomePage= new HRDHomePage();
                    this.NavigationService.Navigate(hrdHomePage);
                }
                else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Ride And Attraction"))
                {
                    CreativeHomePage creativeHomePage = new CreativeHomePage();
                    this.NavigationService.Navigate(creativeHomePage);
                }else if(ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Sales And Marketing"))
                {
                    this.NavigationService.Navigate(new SalesAndMarketingHomePage());
                }else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Construction"))
                {
                    this.NavigationService.Navigate(new ConstructionHomePage());
                }
                else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Accounting And Finance"))
                {
                    this.NavigationService.Navigate(new AccountFinanceHomePage());
                }
                else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Attraction"))
                {
                    this.NavigationService.Navigate(new AttractionHomePage());
                }
                else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Purchasing"))
                {
                    this.NavigationService.Navigate(new PurchasingHomePage());
                }
                else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Kitchen Division"))
                {
                    this.NavigationService.Navigate(new KitchenHomePage());
                }
                else if (ActiveUserController.GetActiveEmployee().Department.DepartmentName.Equals("Dining Room Division"))
                {
                    this.NavigationService.Navigate(new DiningRoomPage());
                }
                MessageBox.Show($"Login Success As {ActiveUserController.GetActiveEmployee().EmployeeName}");
            }
        }

    }
}
