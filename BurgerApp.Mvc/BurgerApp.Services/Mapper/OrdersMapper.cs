using BurgerApp.Data.Models;
using BurgerApp.Services.Models.Burgers;
using BurgerApp.Services.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Mapper
{
    public static class OrdersMapper
    {
        public static OrderModel ToModel(this Order order)
        {
            var burger = order.OrderedBurger.First();
            return new OrderModel
            {
                Id = order.Id,
                FullName = order.FullName,
                Address = order.Address,
                IsDelivered = order.IsDelivered,
                Burger = new BurgerModel
                {
                    Id = burger.Burger.Id,
                    Name = burger.Burger.Name,
                    HasFries = burger.Burger.HasFries,
                    IsVegeterian = burger.Burger.IsVegeterian,
                    IsVegan = burger.Burger.IsVegan,
                    Price = burger.Burger.Price,
                }
            };
        }
            public static OrderDetailsModel ToDetailsModel(this Order order)
            {
                return new OrderDetailsModel
                {
                    Id = order.Id,
                    FullName = order.FullName,
                    Address = order.Address,
                    IsDelivered = order.IsDelivered
                };
            }
        }
    }

