using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrdersMVC.Models;

namespace OrdersMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Orders> tblOrders { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OrdersMVC.Models.Clients> Clients { get; set; }
        public DbSet<OrdersMVC.Models.DeliveryLocations> DeliveryLocations { get; set; }
    }
}
