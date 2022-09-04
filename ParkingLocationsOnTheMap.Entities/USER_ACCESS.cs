using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Entities
{
    public class USER_ACCESS
    {
        public Guid ID { get; set; }
        public DateTime DATE_TIME { get; set; }
        public DateTime TIME_OVER { get; set; }
        public int STATUS { get; set; }
        public  USER USER { get; set; }
    }
}
