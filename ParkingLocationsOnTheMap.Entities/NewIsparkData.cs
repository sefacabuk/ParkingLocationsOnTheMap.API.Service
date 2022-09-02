using System;
using System.ComponentModel.DataAnnotations;

namespace ParkingLocationsOnTheMap.Entities
{
    public class NewIsparkData
    {
        [Key]
        public int id { get; set; }
        public string PARK_NAME { get; set; }
        public string LOCATION_NAME { get; set; }
        public string PARK_TYPE_ID { get; set; }
        public int CAPACITY_OF_PARK { get; set; }
        public string WORKING_TIME { get; set; }
        public string COUNTY_NAME { get; set; }
        public string LONGITUDE { get; set; }
        public string LATITUDE { get; set; }
    }
}
