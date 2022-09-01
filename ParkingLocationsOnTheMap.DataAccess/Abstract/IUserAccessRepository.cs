using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess.Abstract
{
   public interface IUserAccessRepository
    {
        List<UserAccess> GetAllUserAccess();

        UserAccess GetUserAccessId(int id);

        UserAccess CreateUserAccess(UserAccess userAccess);

        UserAccess UpdateUserAccess(UserAccess userAccess);

        void DeleteUserAccess(int id);
    }
}
