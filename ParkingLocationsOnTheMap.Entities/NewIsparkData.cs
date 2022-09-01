using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Spatial;

namespace ParkingLocationsOnTheMap.Entities
{
    public class NewIsparkData
    {
        public int id { get; set; }
        public string PARK_NAME { get; set; }
        public string LOCATION_NAME { get; set; }
        public string PARK_TYPE_ID { get; set; }
        public int CAPACITY_OF_PARK { get; set; }
        public string WORKING_TIME { get; set; }
        public string COUNTY_NAME { get; set; }
        public DbGeography LONGITUDE { get; set; }
        public DbGeography LATITUDE { get; set; }
    }
}
