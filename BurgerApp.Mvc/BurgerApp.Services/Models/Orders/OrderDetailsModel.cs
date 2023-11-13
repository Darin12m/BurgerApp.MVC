using BurgerApp.Services.Models.Burgers;
using BurgerApp.Services.Models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Models.Orders
{
    public class OrderDetailsModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public bool IsDelivered { get; set; }

        public List<BurgerModel>? Burgers { get; set; }

        public LocationModel? OrderLocation { get; set; }
    }
}
