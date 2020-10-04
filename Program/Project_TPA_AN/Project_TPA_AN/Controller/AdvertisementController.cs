using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TPA_AN.Controller
{
    class AdvertisementController
    {
        public static void CreateAdvertisement(Advertisement newAds)
        {
            newAds.AdvertisementStatus = "Active";
            DatabaseSingleton.GetInstance().Advertisements.Add(newAds);
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static void UpdateAds(Advertisement newAds)
        {
            Advertisement rd = DatabaseSingleton.GetInstance().Advertisements.Where(x => x.AdvertisementID == newAds.AdvertisementID).FirstOrDefault();
            rd.AdvertisementDescription = newAds.AdvertisementDescription;
            rd.AdvertisementStatus = newAds.AdvertisementStatus;
            rd.EmployeeID = rd.EmployeeID;
            rd.Deadline = newAds.Deadline;
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void DeleteAds(Advertisement newAds)
        {
            var rslt = DatabaseSingleton.GetInstance().Advertisements.Where(x => x.AdvertisementID == newAds.AdvertisementID).FirstOrDefault();
            rslt.AdvertisementStatus = "Deleted";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static Advertisement SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().Advertisements.Where(x => x.AdvertisementID == id).FirstOrDefault();

        }
    }
}
