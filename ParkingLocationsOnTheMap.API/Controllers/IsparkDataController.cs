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

    public class IsparkDataController : ControllerBase
    {
        private IIsparkDataService _isparkService;

        public IsparkDataController(IIsparkDataService isparkDataService)
        {
            _isparkService = isparkDataService;
        }

        [HttpGet]
        public List<ISPARK_DATA> Get()
        {
            return _isparkService.GetAllIspark();
        }


        [HttpGet("{id}")]
        public ISPARK_DATA Get(int id)
        {
            return _isparkService.GetIsparkDataId(id);
        }

        [HttpPost]
        public ISPARK_DATA Post(ISPARK_DATA isparkData)
        {
            string externalLink = string.Format(" https://data.ibb.gov.tr/api/3/action/datastore_search?resource_id=f4f56e58-5210-4f17-b852-effe356a890c");

            List<ISPARK_DATA> sonucList = new List<ISPARK_DATA>();

            try
            {
                var httpClient = new HttpClient();

                string json = "";
                //json = Newtonsoft.Json.JsonConvert.SerializeObject(Request);
                var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
                var postTask = httpClient.GetAsync(externalLink);
                postTask.Wait();
                var postResult = postTask.Result;
                var responJsonText = postResult.Content.ReadAsStringAsync().Result;

                var o = JsonConvert.DeserializeObject<JObject>(responJsonText);
                var h = o.Value<JObject>("result")
                    .Value<JArray>("records").ToObject<List<ISPARK_DATA>>();


                sonucList = h.ToList();


                foreach (var item in sonucList)
                {
                    isparkData = new ISPARK_DATA
                    {
                        _id = item._id,
                        PARK_NAME = item.PARK_NAME,
                        LOCATION_NAME = item.LOCATION_NAME,
                        PARK_TYPE_ID = item.PARK_TYPE_ID,
                        CAPACITY_OF_PARK = item.CAPACITY_OF_PARK,
                        WORKING_TIME = item.WORKING_TIME,
                        COUNTY_NAME = item.COUNTY_NAME,
                        //LATITUDE - LATITUDE yerleri yanlış geliyor.
                        LATITUDE = item.LONGITUDE,
                        LONGITUDE = item.LATITUDE,

                    };

                     _isparkService.CreateIsparkData(isparkData);
                }


                return isparkData;

            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }


        }

        [HttpPut]
        public ISPARK_DATA Put([FromBody] ISPARK_DATA isparkData)
        {
            return _isparkService.UpdateIsparkData(isparkData);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _isparkService.DeleteIsparkData(id);
        }


    }
}
