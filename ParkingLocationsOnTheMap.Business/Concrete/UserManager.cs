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
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public USER CreateUser(USER user)
        {
            return _userRepository.CreateUser(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public List<USER> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public USER GetUserId(int id)
        {
            return _userRepository.GetUserId(id);
        }

        public USER UpdateUser(USER user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}
