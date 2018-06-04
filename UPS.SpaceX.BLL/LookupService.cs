using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPS.SpaceX.Core;
using UPS.SpaceX.DAL;

namespace UPS.SpaceX.BLL
{
    public class LookupService
    {
        public static List<RecipientDto> GetRecipientTable(String email)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                var recipientTable = (from db in dbContext.Recipients
                                      where db.email == email
                                      //select new Giver()
                                      //{
                                      //    desk = db.desk,
                                      //    date = db.date,
                                      //    email = db.email                                      
                                      //}
                                      select new RecipientDto()
                                      {
                                          desk = db.desk,
                                          date = db.date,
                                          email = db.email
                                      }
                                      ).ToList();


                return recipientTable;
            }
        }

        public static List<GiverDto> GetDonorTable(String email)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                var donorTable = (from db in dbContext.Givers
                                      where db.email == email
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


                return donorTable;
            }
        }

        public static List<GiverDto> GetKP(String email)
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                var KP = (from db in dbContext.Givers
                                  where db.email == email
                                  //select new Giver()
                                  //{
                                  //    desk = db.desk,
                                  //    date = db.date,
                                  //    email = db.email                                      
                                  //}
                                  select new GiverDto()
                                  {
                                      KarmaPoints = db.karmaPoints
                                  }
                                  ).First();

                var results = new List<GiverDto>();
                results.Add(KP);

                return results;
            }
        }

    }
}
