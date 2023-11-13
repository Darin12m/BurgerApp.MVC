using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Models
{
    public class Location : BaseEntity
    {
        public Location() { }

        public Location(string name , string address, DateTime opensAt , DateTime closesAt) 
        {
            Name = name;    
            Address = address;
            OpensAt = opensAt;
            ClosesAt = closesAt;
        
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime OpensAt { get; set; }

        public DateTime ClosesAt { get; set;}
    }
}
