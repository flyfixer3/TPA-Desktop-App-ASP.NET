using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_TPA_AN.Controller;
using Project_TPA_AN.Model;

namespace Project_TPA_AN.Controller
{
    class RequestAttractionController
    {
        public static void CreateRequestAttraction(RequestAttraction newRequest)
        {
            DatabaseSingleton.GetInstance().RequestAttractions.Add(newRequest);
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static void RejectAttraction(int id)
        {
            var rslt = DatabaseSingleton.GetInstance().RequestAttractions.Where(x => x.RequestAttractionID == id).FirstOrDefault();
            rslt.AttractionStatus = "Rejected";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void AcceptAttraction(int id, String action)
        {
            var rslt = DatabaseSingleton.GetInstance().RequestAttractions.Where(x => x.RequestAttractionID == id).FirstOrDefault();
            rslt.AttractionStatus = action;
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void FinishRequestAttraction(int id)
        {
            var rslt = DatabaseSingleton.GetInstance().RequestAttractions.Where(x => x.RequestAttractionID == id).FirstOrDefault();
            rslt.AttractionStatus = "Finish";
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static RequestAttraction SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().RequestAttractions.Where(x => x.RequestAttractionID == id).FirstOrDefault();

        }

    }
}
