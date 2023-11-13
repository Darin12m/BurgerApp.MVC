using BurgerApp.Data.Models;
using BurgerApp.Data.Repositories;
using BurgerApp.Services.Mapper;
using BurgerApp.Services.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Services.Implementation
{
    public class OrderServices : IOrderServices
    {
        private readonly IRepository<Order> repository;

        public OrderServices(IRepository<Order> repository)
        {
            this.repository = repository;
        }

        public void Create(CreateOrderModel createModel)
        {
            if (createModel.OrderedBurgerId == 0)
            {
                throw new Exception("Invalid Burger");
            }

            var order = new Order(createModel.FullName, createModel.Address, createModel.IsDelivered)
            {
                Id = createModel.OrderId
            };


            
                order.OrderedBurger.Add(new OrderedBurgers()
                {
                    BurgerId = createModel.OrderedBurgerId,
                    OrderId = order.Id,
                });


                repository.Save(order);
            
        }

        public void Delete(int id)
        {
            var order = repository.GetById(id);
            if (order == null)
            {
                throw new Exception();
            }
            repository.Delete(order);
        }

        public IEnumerable<OrderModel> GetAll()
        {
            IEnumerable<Order> orders = repository.GetAll();

            return orders.Select(x => x.ToModel());
        }

        public OrderDetailsModel GetById(int id)
        {
            var order = repository.GetById(id);
            if (order == null)
            {
                throw new Exception();
            }
            return order.ToDetailsModel();
        }

        public void Update(OrderModel model)
        {
            Order? order = repository.GetById(model.Id);

            if (order == null)
                throw new Exception("Order does not exist!");

            order.Address = model.Address;
            order.IsDelivered = model.IsDelivered;
            order.FullName = model.FullName;

            repository.Update(order);
        }
    }
}
