using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Models.Burgers
{
    public class BurgerModel
    {
        public BurgerModel() { }


        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsVegan { get; set; }

        public bool HasFries { get; set; }
    }
}
