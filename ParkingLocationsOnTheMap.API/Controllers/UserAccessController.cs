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

    public class UserAccessController : ControllerBase
    {
        private IUserAccessService _newIsparkService;

        public UserAccessController(IUserAccessService userAccessService)
        {
            _newIsparkService = userAccessService;
        }

        [HttpGet]
        public List<UserAccess> Get()
        {
            return _newIsparkService.GetAllUserAccess();
        }


        [HttpGet("{id}")]
        public UserAccess Get(int id)
        {
            return _newIsparkService.GetUserAccessId(id);
        }

        [HttpPost]
        public UserAccess Post(UserAccess newIsparkData)
        {
            return _newIsparkService.CreateUserAccess(newIsparkData);
        }

        [HttpPut]
        public UserAccess Put([FromBody] UserAccess newIsparkData)
        {
            return _newIsparkService.UpdateUserAccess(newIsparkData);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _newIsparkService.DeleteUserAccess(id);
        }


    }
}
