using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess.Concrete
{
    public class NewIsparkDataRepository : INewIsparkDataRepository
    {
        public NewIsparkData CreateNewIsparkData(NewIsparkData newIspark)   
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {

                parkingLocationsOnTheMapDbContext.NewIsparkData.Add(newIspark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return newIspark;
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

        public NewIsparkData UpdateNewIsparkData(NewIsparkData newIspark)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                parkingLocationsOnTheMapDbContext.NewIsparkData.Update(newIspark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return newIspark;

            }
        }
    }
}
