using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class FundController
    {
        public static void CreateFundRequest(FundRequest newFundRequest)
        {
            newFundRequest.FundStatus = "Pending Request";
            DatabaseSingleton.GetInstance().FundRequests.Add(newFundRequest);
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static FundRequest SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().FundRequests.Where(x => x.FundId == id).FirstOrDefault();
        }
        public static void AcceptingFundRequest(int id)
        {

            var rslt = DatabaseSingleton.GetInstance().FundRequests.Where(x => x.FundId == id).FirstOrDefault();
            rslt.FundStatus = "Accepted";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void RejectingFundRequest(int id)
        {
            var rslt = DatabaseSingleton.GetInstance().FundRequests.Where(x => x.FundId == id).FirstOrDefault();
            rslt.FundStatus = "Rejected";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
    }
}
