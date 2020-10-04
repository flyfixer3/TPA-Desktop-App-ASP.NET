using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class PurchaseRequestController
    {
        public static void CreatePurchaseRequest(PurchaseRequest purchaseRequest)
        {
            purchaseRequest.PurchaseStatus = "Pending";
            DatabaseSingleton.GetInstance().PurchaseRequests.Add(purchaseRequest);
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void WaitingFundRequest(int id)
        {
            var rslt = DatabaseSingleton.GetInstance().PurchaseRequests.Where(x => x.PurchaseID == id).FirstOrDefault();
            rslt.PurchaseStatus = "Waiting For Fund";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static PurchaseRequest SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().PurchaseRequests.Where(x => x.PurchaseID == id).FirstOrDefault();
        }
        public static void AcceptingPurchaseRequest(PurchaseRequest purchaseRequest)
        {
            var rslt = DatabaseSingleton.GetInstance().PurchaseRequests.Where(x => x.PurchaseID == purchaseRequest.PurchaseID).FirstOrDefault();
            rslt.PurchaseStatus = "Accepted";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void RejectingPurchaseRequest(PurchaseRequest purchaseRequest)
        {
            var rslt = DatabaseSingleton.GetInstance().PurchaseRequests.Where(x => x.PurchaseID == purchaseRequest.PurchaseID).FirstOrDefault();
            rslt.PurchaseStatus = "Rejected";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
    }
}
