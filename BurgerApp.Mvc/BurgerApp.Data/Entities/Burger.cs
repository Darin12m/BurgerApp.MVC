using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Models
{
    public class Burger : BaseEntity
    {
        public Burger() 
        { 
        
        }

        public Burger (string name,int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsVegan { get; set; }

        public bool HasFries { get; set; }

    }
}
