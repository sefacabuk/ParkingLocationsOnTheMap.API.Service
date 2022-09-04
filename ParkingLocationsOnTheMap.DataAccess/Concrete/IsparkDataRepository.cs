using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess.Concrete
{
    public class IsparkDataRepository : IIsparkDataRepository
    {
        public ISPARK_DATA CreateIsparkData(ISPARK_DATA ispark)   
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                
                var isparkControl = GetIsparkDataId(ispark._id);

                if (isparkControl != null)
                {
                    parkingLocationsOnTheMapDbContext.IsparkData.Update(ispark);

                    parkingLocationsOnTheMapDbContext.SaveChanges();

                    return ispark;
                }

                parkingLocationsOnTheMapDbContext.IsparkData.Add(ispark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return ispark;
            }
        }

        public void DeleteIsparkData(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                var deleteIspark = GetIsparkDataId(id);

                parkingLocationsOnTheMapDbContext.IsparkData.Remove(deleteIspark);

                parkingLocationsOnTheMapDbContext.SaveChanges();
            }
        }

        public List<ISPARK_DATA> GetAllIspark()
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.IsparkData.ToList();
            }
        }

        public ISPARK_DATA GetIsparkDataId(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.IsparkData.Find(id);
            }
        }

        public ISPARK_DATA UpdateIsparkData(ISPARK_DATA ispark)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                parkingLocationsOnTheMapDbContext.IsparkData.Update(ispark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return ispark;

            }
        }
    }
}
