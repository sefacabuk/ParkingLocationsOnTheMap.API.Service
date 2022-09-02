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

    public class NewIsparkDataController : ControllerBase
    {
        private INewIsparkDataService _newIsparkService;

        public NewIsparkDataController(INewIsparkDataService newIsparkDataService)
        {
            _newIsparkService = newIsparkDataService;
        }

        [HttpGet]
        public List<NewIsparkData> Get()
        {
            return _newIsparkService.GetAllNewIspark();
        }


        [HttpGet("{id}")]
        public NewIsparkData Get(int id)
        {
            return _newIsparkService.GetNewIsparkDataId(id);
        }

        [HttpPost]
        public NewIsparkData Post(NewIsparkData newIsparkData)
        {
            return _newIsparkService.CreateNewIsparkData(newIsparkData);
        }

        [HttpPut]
        public NewIsparkData Put([FromBody] NewIsparkData newIsparkData)
        {
            return _newIsparkService.UpdateNewIsparkData(newIsparkData);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _newIsparkService.DeleteNewIsparkData(id);
        }


    }
}
