using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess.Concrete
{
    public class UserAccessRepository : IUserAccessRepository
    {
        public USER_ACCESS CreateUserAccess(USER_ACCESS userAccess)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                userAccess.ID = new Guid();

                parkingLocationsOnTheMapDbContext.UserAccess.Add(userAccess);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return userAccess;
            }
        }

        public void DeleteUserAccess(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                var deleteUSer = GetUserAccessId(id);
                parkingLocationsOnTheMapDbContext.UserAccess.Remove(deleteUSer);

                parkingLocationsOnTheMapDbContext.SaveChanges();

            }
        }

        public List<USER_ACCESS> GetAllUserAccess()
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.UserAccess.ToList();
            }
        }

        public USER_ACCESS GetUserAccessId(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.UserAccess.Find(id);
            }
        }

        public USER_ACCESS UpdateUserAccess(USER_ACCESS userAccess)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {

                parkingLocationsOnTheMapDbContext.UserAccess.Update(userAccess);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return userAccess;
            }
        }
    }
}
