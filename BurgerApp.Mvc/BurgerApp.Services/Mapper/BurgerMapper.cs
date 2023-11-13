using BurgerApp.Data.Models;
using BurgerApp.Services.Models.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Mapper
{
    public static class BurgerMapper
    {
        public static BurgerModel ToModel(this Burger burger)
        {
            return new BurgerModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                IsVegeterian = burger.IsVegeterian,
                IsVegan = burger.IsVegan,
                HasFries = burger.HasFries,
            };
        }

        public static BurgerDetailsModel ToDetailsModel(this Burger burger)
        {
            return new BurgerDetailsModel
            {
                Id = burger.Id,
                Name = burger.Name,
                Price = burger.Price,
                IsVegeterian = burger.IsVegeterian,
                IsVegan = burger.IsVegan,
                HasFries = burger.HasFries,
            };
        }
    }
}
