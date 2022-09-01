using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        
        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(50)]
        public string SURNAME { get; set; }

        [StringLength(50)]
        public string USER_NAME { get; set; }

        [StringLength(50)]
        public string PASSWORD { get; set; }
    }
}
