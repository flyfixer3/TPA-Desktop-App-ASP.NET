using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_TPA_AN.Model;
namespace Project_TPA_AN.Controller
{
    class DatabaseSingleton
    {
        private static UnderTheSeaEntities myDatabase = null;

        public static UnderTheSeaEntities GetInstance()
        {
            if (myDatabase == null)
            {
                myDatabase = new UnderTheSeaEntities();
            }
            return myDatabase;
        }


    }
}
