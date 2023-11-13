using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Models
{
    public class Order : BaseEntity
    {

        public Order() { }

        public Order(string fullName , string address , bool isDelivered)
        {
            FullName = fullName;
            Address = address;
            IsDelivered = isDelivered;
            OrderedBurger = new List<OrderedBurgers>();
        }
        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public bool IsDelivered { get; set; }

        public ICollection<OrderedBurgers> OrderedBurger { get; set; } 
    }
}
