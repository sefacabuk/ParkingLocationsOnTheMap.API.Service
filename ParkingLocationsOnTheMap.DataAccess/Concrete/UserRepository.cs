using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public USER CreateUser(USER user)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                user.ID = new Guid();

                parkingLocationsOnTheMapDbContext.Users.Add(user);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                var deleteUSer = GetUserId(id);
                parkingLocationsOnTheMapDbContext.Users.Remove(deleteUSer);

                parkingLocationsOnTheMapDbContext.SaveChanges();

            }
        }

        public List<USER> GetAllUser()
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.Users.ToList();
            }
        }

        public USER GetUserId(int id)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {
                return parkingLocationsOnTheMapDbContext.Users.Find(id);
            }
        }

        public USER UpdateUser(USER user)
        {
            using (var parkingLocationsOnTheMapDbContext = new ParkingLocationsOnTheMapDbContext())
            {

                parkingLocationsOnTheMapDbContext.Users.Update(user);

                parkingLocationsOnTheMapDbContext.SaveChanges();

                return user;
            }
        }
    }
}
