using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess.Concrete
{
    public class NewIsparkDataRepository : INewNewIsparkDataRepository
    {
        public NewIsparkData CreateNewIsparkData(NewIsparkData ispark)   
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {

                parkingLocationsOnTheMapDbContext.NewIsparkData.Add(ispark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return ispark;
            }
        }

        public void DeleteNewIsparkData(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                var deleteNewIspark = GetNewIsparkDataId(id);

                parkingLocationsOnTheMapDbContext.NewIsparkData.Remove(deleteNewIspark);

                parkingLocationsOnTheMapDbContext.SaveChanges();
            }
        }

        public List<NewIsparkData> GetAllNewIspark()
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.NewIsparkData.ToList();
            }
        }

        public NewIsparkData GetNewIsparkDataId(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.NewIsparkData.Find(id);
            }
        }

        public NewIsparkData UpdateNewIsparkData(NewIsparkData ispark)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                parkingLocationsOnTheMapDbContext.NewIsparkData.Update(ispark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return ispark;

            }
        }
    }
}
