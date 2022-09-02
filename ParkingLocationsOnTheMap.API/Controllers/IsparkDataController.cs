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

    public class IsparkDataController : ControllerBase
    {
        private IIsparkDataService _isparkService;

        public IsparkDataController(IIsparkDataService isparkDataService)
        {
            _isparkService = isparkDataService;
        }

        [HttpGet]
        public List<IsparkData> Get()
        {
            return _isparkService.GetAllIspark();
        }


        [HttpGet("{id}")]
        public IsparkData Get(int id)
        {
            return _isparkService.GetIsparkDataId(id);
        }

        //[HttpPost]
        //public IsparkData Post(IsparkData isparkData)
        //{
        //    return _isparkService.CreateIsparkData(isparkData);
        //}

        [HttpPut]
        public IsparkData Put([FromBody] IsparkData isparkData)
        {
            return _isparkService.UpdateIsparkData(isparkData);
        }
        
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    _isparkService.DeleteIsparkData(id);
        //}


    }
}
