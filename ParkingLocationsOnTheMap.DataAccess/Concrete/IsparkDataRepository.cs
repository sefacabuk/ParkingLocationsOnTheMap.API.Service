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
        public IsparkData CreateIsparkData(IsparkData newIspark)   
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {

                parkingLocationsOnTheMapDbContext.IsparkData.Add(newIspark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return newIspark;
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

        public List<IsparkData> GetAllIspark()
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.IsparkData.ToList();
            }
        }

        public IsparkData GetIsparkDataId(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.IsparkData.Find(id);
            }
        }

        public IsparkData UpdateIsparkData(IsparkData newIspark)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                parkingLocationsOnTheMapDbContext.IsparkData.Update(newIspark);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return newIspark;

            }
        }
    }
}
