using System.Collections.Generic;
using System.Linq;
using UPS.SpaceX.Core;
using UPS.SpaceX.DAL;

namespace UPS.SpaceX.BLL
{
    public class SpaceXCommon
    {
        public static List<DeskDto> GetAvailableDesks()
        {
            using (UPSSpaceXEntities dbContext = new UPSSpaceXEntities())
            {
                var availableDesks = (from desk in dbContext.Desks
                                      where desk.AvailableFlag == true
                                      select new DeskDto()
                                      {
                                          Id = desk.Id,
                                          Name = desk.Name,
                                          IsAvailable = true
                                      }).ToList();

                return availableDesks;
            }
        }        
    }
}
