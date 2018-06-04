using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.SpaceX.Core;
using UPS.SpaceX.DAL;

namespace UPS.SpaceX.BLL
{
    public class DonorService
    {
        public static bool InsertRecord(Giver giver)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                dbContext.Givers.Add(giver);
                //specifically access the 
                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

        public static bool UpdateKP(Giver giver)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                var query = from db in dbContext.Givers where (db.email == giver.email) select db;

                // Execute the query, and change the column values
                // you want to change.
                foreach (Giver db in query)
                {
                    db.karmaPoints = db.karmaPoints + 100;
                    // Insert any additional changes to column values.
                }

                dbContext.SaveChanges();

                return true;
            }
            return false;
        }

    }

}
