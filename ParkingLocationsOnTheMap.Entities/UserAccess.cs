using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Entities
{
    public class UserAccess
    {
        public Guid ID { get; set; }
        public DateTime DATE_TIME { get; set; }
        public DateTime TIME_OVER { get; set; }
        public int STATUS { get; set; }
        public  User User { get; set; }
    }
}
