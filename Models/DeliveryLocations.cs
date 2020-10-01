using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersMVC.Models
{
    public class DeliveryLocations
    {
        //  Primary Key for delivery location table
        [Key]
        public int DLId { get; set; }
        // name of the location
        public string LocationName { get; set; }
        // address of the location
        public string Address { get; set; }
        // city of the location
        public string City { get; set; }
        // state of the location
        public string State { get; set; }
        // time from delivery start
        [DataType(DataType.Time)]
        public DateTime TimeFrom { get; set; }
        [DataType(DataType.Time)]
        // devilvery end time
        public DateTime TimeTill { get; set; }
        // no of days available
        public int DayAvailable { get; set; }


    }
}
