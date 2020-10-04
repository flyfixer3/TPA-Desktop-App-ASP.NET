using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class ActiveUserController
    {
        private static Employee activeEmployee;

        public static Employee GetActiveEmployee()
        {
            return activeEmployee;
        }

        public static void SetActiveEmployee(Employee employee)
        {
            activeEmployee = employee;
        }

    }
}
