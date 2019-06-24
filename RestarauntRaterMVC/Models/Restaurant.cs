using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestarauntRaterMVC.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string Name { get; set; }
        [Display(Name="Food Type")]
        public string FoodType { get; set; }
        public double Rating { get; set; }
    }

    public class RestaurantDbContext : DbContext// Db=database
    {
        public DbSet<Restaurant> Restaurants { get; set; }//snapshot of the database
    }
}