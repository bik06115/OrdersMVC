using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersMVC.Models
{
    // Database Table for managing product orders in stock
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public string ProductName { get; set; } // product name
        [Required]
        public int Quantity { get; set; } // qty of the product
        [Required]
        public double Price { get; set; } // wholesale price
        [Required]
        [DataType(DataType.Date)] // Manufacturing date of product
        public DateTime ManufacturingDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpireDate { get; set; } // Expiring date of product

    }
}
