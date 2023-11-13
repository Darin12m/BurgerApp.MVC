using BurgerApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Database
{
    public class BurgerAppDbContext : DbContext 
    {
        public BurgerAppDbContext() { }

        public BurgerAppDbContext(DbContextOptions<BurgerAppDbContext> options)
            : base(options) 
        { 

        }

        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Location > Locations { get; set; }
        
    }
}
