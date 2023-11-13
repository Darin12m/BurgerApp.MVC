using BurgerApp.Services.Models.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Models.Orders
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public bool IsDelivered { get; set; }

        public BurgerModel Burger { get; set; } = new BurgerModel();

    }
}
