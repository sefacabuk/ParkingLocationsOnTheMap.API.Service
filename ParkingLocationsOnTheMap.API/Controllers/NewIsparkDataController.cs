using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ParkingLocationsOnTheMap.Business.Abstract;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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
        public List<NEW_ISPARK_DATA> Get()
        {
            return _newIsparkService.GetAllNewIspark();
        }


        [HttpGet("{id}")]
        public NEW_ISPARK_DATA Get(int id)
        {
            return _newIsparkService.GetNewIsparkDataId(id);
        }

        [HttpPost]
        public NEW_ISPARK_DATA Post(NEW_ISPARK_DATA newIsparkData)
        {
            return _newIsparkService.CreateNewIsparkData(newIsparkData);
        }

        [HttpPut]
        public NEW_ISPARK_DATA Put([FromBody] NEW_ISPARK_DATA newIsparkData)
        {
            return _newIsparkService.UpdateNewIsparkData(newIsparkData);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _newIsparkService.DeleteNewIsparkData(id);
        }

        //[HttpPost]
        //public NEW_ISPARK_DATA UpdateIsparkAllData(NEW_ISPARK_DATA newIsparkData)
        //{
        //    string externalLink = string.Format(" https://data.ibb.gov.tr/api/3/action/datastore_search?resource_id=f4f56e58-5210-4f17-b852-effe356a890c");

        //    List<NEW_ISPARK_DATA> sonucList = new List<NEW_ISPARK_DATA>();

        //    try
        //    {
        //        var httpClient = new HttpClient();

        //        string json = "";
        //        //json = Newtonsoft.Json.JsonConvert.SerializeObject(Request);
        //        var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
        //        var postTask = httpClient.GetAsync(externalLink);
        //        postTask.Wait();
        //        var postResult = postTask.Result;
        //        var responJsonText = postResult.Content.ReadAsStringAsync().Result;

        //        var o = JsonConvert.DeserializeObject<JObject>(responJsonText);
        //        var h = o.Value<JObject>("result")
        //            .Value<JArray>("records").ToObject<List<NEW_ISPARK_DATA>>();


        //        sonucList = h.ToList();


        //        foreach (var item in sonucList)
        //        {
        //            newIsparkData = new NEW_ISPARK_DATA
        //            {
        //                //ID = item.ID,
        //                PARK_NAME = item.PARK_NAME,
        //                LOCATION_NAME = item.LOCATION_NAME,
        //                PARK_TYPE_ID = item.PARK_TYPE_ID,
        //                CAPACITY_OF_PARK = item.CAPACITY_OF_PARK,
        //                WORKING_TIME = item.WORKING_TIME,
        //                COUNTY_NAME = item.COUNTY_NAME,
        //                //LATITUDE - LATITUDE yerleri yanlış geliyor.
        //                LATITUDE = item.LONGITUDE,
        //                LONGITUDE = item.LATITUDE,
        //                ISPARK_DATA_ID = item.ID
        //            };

        //            _newIsparkService.UpdateIsparkAllData(newIsparkData);
        //        }


        //        return newIsparkData;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new(ex.Message);
        //    }


        //}

    }
}
