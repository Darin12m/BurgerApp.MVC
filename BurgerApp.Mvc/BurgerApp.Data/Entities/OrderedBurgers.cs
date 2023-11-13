using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Models
{
    public class OrderedBurgers : BaseEntity
    {
      
        public OrderedBurgers() { }

        public int OrderId { get; set; }

        public int BurgerId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } 
        
        
        [ForeignKey(nameof(BurgerId))]
        public Burger Burger { get; set; }
    }
}
