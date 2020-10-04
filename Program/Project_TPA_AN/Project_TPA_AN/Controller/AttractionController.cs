using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_TPA_AN.Model;

namespace Project_TPA_AN.Controller
{
    class AttractionController
    {
        public static void CreateRide(RequestAttraction requestedAttraction)
        {
            Attraction rd = new Attraction();
            rd.AttractionName = requestedAttraction.AttractionName;
            rd.AttractionDescription= requestedAttraction.AttractionDescription;
            rd.AttractionHowToWork = requestedAttraction.AttractionHowToWork;
            rd.AttractionStartDate = requestedAttraction.AttractionStartDate;
            rd.AttractionParticipant = requestedAttraction.AttractionParticipant;
            rd.AttractionStatus = "Active";
            DatabaseSingleton.GetInstance().Attractions.Add(rd);
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static void deleteAttraction(RequestAttraction requestAttraction)
        {
            var rslt = DatabaseSingleton.GetInstance().Attractions.Where(x => x.AttractionID == requestAttraction.AttractionID).FirstOrDefault();
            rslt.AttractionStatus = "Deleted";
            DatabaseSingleton.GetInstance().SaveChanges();
        }
        public static Attraction SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().Attractions.Where(x => x.AttractionID == id).FirstOrDefault();

        }

        public static void UpdateAttraction(RequestAttraction requestAttraction)
        {
            Attraction rd = DatabaseSingleton.GetInstance().Attractions.Where(x => x.AttractionID == requestAttraction.AttractionID).FirstOrDefault();
            rd.AttractionName = requestAttraction.AttractionName;
            rd.AttractionDescription = requestAttraction.AttractionDescription;
            rd.AttractionHowToWork = requestAttraction.AttractionHowToWork;
            rd.AttractionStartDate = requestAttraction.AttractionStartDate;
            rd.AttractionParticipant = requestAttraction.AttractionParticipant;
            DatabaseSingleton.GetInstance().SaveChanges();
        }
    }
}
