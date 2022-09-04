using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Business.Abstract
{
    public interface IUserAccessService
    {
        List<USER_ACCESS> GetAllUserAccess();

        USER_ACCESS GetUserAccessId(int id);

        USER_ACCESS CreateUserAccess(USER_ACCESS userAccess);

        USER_ACCESS UpdateUserAccess(USER_ACCESS userAccess);

        void DeleteUserAccess(int id);
    }
}
