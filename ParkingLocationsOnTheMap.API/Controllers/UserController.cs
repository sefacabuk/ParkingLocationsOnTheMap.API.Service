using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLocationsOnTheMap.Business.Abstract;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private IUserService _newIsparkService;

        public UserController(IUserService userService)
        {
            _newIsparkService = userService;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _newIsparkService.GetAllUser();
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _newIsparkService.GetUserId(id);
        }

        [HttpPost]
        public User Post(User newIsparkData)
        {
            return _newIsparkService.CreateUser(newIsparkData);
        }

        [HttpPut]
        public User Put([FromBody] User newIsparkData)
        {
            return _newIsparkService.UpdateUser(newIsparkData);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _newIsparkService.DeleteUser(id);
        }


    }
}
