using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.SpaceX.Core;
using UPS.SpaceX.DAL;

namespace UPS.SpaceX.BLL
{
   public class ReserveService
    {
        public static List<GiverDto> GetGivers(DateTime AvailableDate)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                var availableDesks = (from db in dbContext.Givers
                                      where (db.isAvailable == true && db.date == AvailableDate)
                                      //select new Giver()
                                      //{
                                      //    desk = db.desk,
                                      //    date = db.date,
                                      //    email = db.email                                      
                                      //}
                                      select new GiverDto()
                                      {
                                          Desk = db.desk,
                                          Date = db.date,
                                          Email = db.email
                                      }
                                      ).ToList();


                return availableDesks;
            }
        }

        public static bool InsertRecord(Recipient recipient)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                dbContext.Recipients.Add(recipient);
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        public static bool UpdateDonorFlag(Giver giver)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                var query = from db in dbContext.Givers where (db.desk == giver.desk && db.date == giver.date) select db;

                // Execute the query, and change the column values
                // you want to change.
                foreach (Giver db in query)
                {
                    db.isAvailable = false;                    
                    // Insert any additional changes to column values.
                }
                
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }




    }
}
