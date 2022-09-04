using ParkingLocationsOnTheMap.Business.Abstract;
using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.DataAccess.Concrete;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Business.Concrete
{
    public class UserAccessManager : IUserAccessService
    {
        private IUserAccessRepository _userAccessRepository;

        public UserAccessManager(IUserAccessRepository userAccessRepository)
        {
            _userAccessRepository = userAccessRepository;
        }

        public USER_ACCESS CreateUserAccess(USER_ACCESS userAccess)
        {
            return _userAccessRepository.CreateUserAccess(userAccess);
        }

        public void DeleteUserAccess(int id)
        {
            _userAccessRepository.DeleteUserAccess(id);
        }

        public List<USER_ACCESS> GetAllUserAccess()
        {
            return _userAccessRepository.GetAllUserAccess();
        }

        public USER_ACCESS GetUserAccessId(int id)
        {
            return _userAccessRepository.GetUserAccessId(id);
        }

        public USER_ACCESS UpdateUserAccess(USER_ACCESS userAccess)
        {
            return _userAccessRepository.UpdateUserAccess(userAccess);
        }
    }
}
