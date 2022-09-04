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
        List<USER> GetAllUser();

        USER GetUserId(int id);

        USER CreateUser(USER user);

        USER UpdateUser(USER user);

        void DeleteUser(int id);
    }
}
