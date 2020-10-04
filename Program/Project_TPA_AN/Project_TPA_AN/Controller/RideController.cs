using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class RideController
    {
        public static void CreateRide(RequestRide requestedRide)
        {
            Ride rd = new Ride();
            rd.RideName = requestedRide.RideName;
            rd.RideDescription = requestedRide.RideDescription;
            rd.RideHowToWork = requestedRide.RideHowToWork;
            rd.RideType = requestedRide.RideType;
            rd.RideSafetyInformation = requestedRide.RideSafetyInformation;
            rd.RideStatus_ = "Waiting For Construction To Add";
            DatabaseSingleton.GetInstance().Rides.Add(rd);
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void deleteRide(RequestRide ride)
        {
            var rslt = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == ride.RideID).FirstOrDefault();
            rslt.RideStatus_ = "Waiting For Construction To Delete";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void ProgressDelete(Ride ride)
        {
            var rslt = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == ride.RideID).FirstOrDefault();
            rslt.RideStatus_ = "In Progress To Delete";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void ProgressUpdate(Ride ride)
        {
            var rslt = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == ride.RideID).FirstOrDefault();
            rslt.RideStatus_ = "In Progress To Update";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void ProgressAdd(Ride ride)
        {
            var rslt = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == ride.RideID).FirstOrDefault();
            rslt.RideStatus_ = "In Progress To Add";
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static Ride SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == id).FirstOrDefault();

        }
        public static void FinishUpdateRide(Ride ride)
        {
            var rslt = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == ride.RideID).FirstOrDefault();
            rslt.RideStatus_ = "Actived";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void FinishAddRide(Ride ride)
        {
            var rslt = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == ride.RideID).FirstOrDefault();
            rslt.RideStatus_ = "Actived";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void FinishDeleteRide(Ride ride)
        {
            var rslt = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == ride.RideID).FirstOrDefault();
            rslt.RideStatus_ = "Deleted";
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static void UpdateRide(RequestRide requestedRide)
        {
            Ride rd = DatabaseSingleton.GetInstance().Rides.Where(x => x.RideID == requestedRide.RideID).FirstOrDefault();
            rd.RideName = requestedRide.RideName;
            rd.RideDescription = requestedRide.RideDescription;
            rd.RideHowToWork = requestedRide.RideHowToWork;
            rd.RideType = requestedRide.RideType;
            rd.RideSafetyInformation = requestedRide.RideSafetyInformation;
            rd.RideStatus_ = "Waiting For Construction To Update";
            DatabaseSingleton.GetInstance().SaveChanges();
        }

    }
}
