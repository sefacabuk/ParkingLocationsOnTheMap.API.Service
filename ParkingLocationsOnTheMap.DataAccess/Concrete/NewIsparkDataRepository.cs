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
        public NEW_ISPARK_DATA CreateNewIsparkData(NEW_ISPARK_DATA newIspark)   
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

        public List<NEW_ISPARK_DATA> GetAllNewIspark()
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.NewIsparkData.ToList();
            }
        }

        public NEW_ISPARK_DATA GetNewIsparkDataId(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.NewIsparkData.Find(id);
            }
        }

        public NEW_ISPARK_DATA UpdateNewIsparkData(NEW_ISPARK_DATA newIspark)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                parkingLocationsOnTheMapDbContext.NewIsparkData.Update(newIspark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return newIspark;

            }
        }

        //public NEW_ISPARK_DATA UpdateIsparkAllData(NEW_ISPARK_DATA newIspark)
        //{
        //    using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
        //    {

        //        var newIsparkControl = parkingLocationsOnTheMapDbContext.NewIsparkData
        //            .Where(x => x.ISPARK_DATA_ID == newIspark.ID).FirstOrDefault();

        //        if (newIsparkControl != null)
        //        {
        //            parkingLocationsOnTheMapDbContext.NewIsparkData.Update(newIspark);

        //            parkingLocationsOnTheMapDbContext.SaveChanges();

        //            return newIspark;
        //        }

        //        parkingLocationsOnTheMapDbContext.NewIsparkData.Add(newIspark);

        //        parkingLocationsOnTheMapDbContext.SaveChanges();

        //        return newIspark;
        //    }
        //}

    }
}
