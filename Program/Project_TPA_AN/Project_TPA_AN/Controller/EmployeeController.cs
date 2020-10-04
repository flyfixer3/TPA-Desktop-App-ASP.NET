using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class EmployeeController
    {
        public static Employee DoSearchEmployee(String username, String password)
        {
            Employee employee = DatabaseSingleton.GetInstance().Employees.Where(x => x.EmployeeUsername.Equals(username) && x.EmployeePassword.Equals(password)).FirstOrDefault();

            if (employee == null || employee.EmployeeBannedStatus.Equals("True"))
            {
                return null;
            }            

            return employee;
        }

        public static Employee DoSearchEmployee(int id)
        {
            Employee employee = DatabaseSingleton.GetInstance().Employees.Where(x => x.EmployeeID.Equals(id)).FirstOrDefault();
            return employee;
        }
    }
}
