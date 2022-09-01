﻿using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.DataAccess.Abstract
{
   public interface IUserRepository
    {
        List<User> GetAllUser();

        User GetUserId(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
