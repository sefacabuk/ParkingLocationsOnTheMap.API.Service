using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUser();

        User GetUserId(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
