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

        public UserAccess CreateUserAccess(UserAccess userAccess)
        {
            return _userAccessRepository.CreateUserAccess(userAccess);
        }

        public void DeleteUserAccess(int id)
        {
            _userAccessRepository.DeleteUserAccess(id);
        }

        public List<UserAccess> GetAllUserAccess()
        {
            return _userAccessRepository.GetAllUserAccess();
        }

        public UserAccess GetUserAccessId(int id)
        {
            return _userAccessRepository.GetUserAccessId(id);
        }

        public UserAccess UpdateUserAccess(UserAccess userAccess)
        {
            return _userAccessRepository.UpdateUserAccess(userAccess);
        }
    }
}
