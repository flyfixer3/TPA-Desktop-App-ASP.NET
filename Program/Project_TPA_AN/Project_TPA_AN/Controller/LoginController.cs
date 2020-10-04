using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class LoginController
    {
        public static Employee DoUserLogin(String username, String password)
        {
            return EmployeeController.DoSearchEmployee(username, password);
        }

        public static void DoFeedActiveEmployee(int id)
        {
            ActiveUserController.SetActiveEmployee(EmployeeController.DoSearchEmployee(id));
        }
    }
}
