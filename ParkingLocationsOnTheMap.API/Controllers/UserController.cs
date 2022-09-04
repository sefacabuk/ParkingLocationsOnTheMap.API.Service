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
        public List<USER> Get()
        {
            return _newIsparkService.GetAllUser();
        }


        [HttpGet("{id}")]
        public USER Get(int id)
        {
            return _newIsparkService.GetUserId(id);
        }

        [HttpPost]
        public USER Post(USER newIsparkData)
        {
            return _newIsparkService.CreateUser(newIsparkData);
        }

        [HttpPut]
        public USER Put([FromBody] USER newIsparkData)
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
