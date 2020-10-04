using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class RequestRideController
    {
        public static void CreateRequestRide(RequestRide newRequest)
        {
            DatabaseSingleton.GetInstance().RequestRides.Add(newRequest);
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void RejectRide(int id)
        {
            var rslt = DatabaseSingleton.GetInstance().RequestRides.Where(x => x.RequestRideID == id).FirstOrDefault();
            rslt.RideStatus_ = "Rejected";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void AcceptRide(int id, String action)
        {
            var rslt = DatabaseSingleton.GetInstance().RequestRides.Where(x => x.RequestRideID == id).FirstOrDefault();
            rslt.RideStatus_ = action;
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void FinishRequestRide(int id)
        {
            var rslt = DatabaseSingleton.GetInstance().RequestRides.Where(x => x.RequestRideID == id).FirstOrDefault();
            rslt.RideStatus_ = "Applied to Construct";
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static RequestRide SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().RequestRides.Where(x => x.RequestRideID == id).FirstOrDefault();

        }

    }
}
