using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersMVC.Models
{
    public class Clients //  clients model class
    {
        [Key] // unique key
        public int ClientId { get; set; }
        // Name of the client
        public string Name { get; set; }
        // client has purchased membership
        public bool Membership { get; set; }
    }
}
