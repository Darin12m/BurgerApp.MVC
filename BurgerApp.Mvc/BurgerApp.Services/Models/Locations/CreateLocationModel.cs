using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Models.Locations
{
    public class CreateLocationModel
    {
        public int LocationId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public DateTime OpensAt { get; set; }
        public DateTime ClosesAt { get; set; }
    }
}
