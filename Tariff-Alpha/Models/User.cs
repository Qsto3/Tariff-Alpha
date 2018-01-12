using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Alpha.Models
{
    public class User
    {
        public int UserID { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    public class AlphaDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
       // public DbSet<Order> Orders { get; set; }
    }

}