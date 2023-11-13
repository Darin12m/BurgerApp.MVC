using BurgerApp.Data.Database;
using BurgerApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly BurgerAppDbContext _dbContext;

        public OrderRepository(BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
               

        public IEnumerable<Order> GetAll()
        {
            return _dbContext.Orders
                 .Include(x => x.OrderedBurger)
                 .ThenInclude(x => x.Burger);
        }

        public Order? GetById(int id)
        {
            return _dbContext.Orders
                .Include(x => x.OrderedBurger)
                .ThenInclude(x => x.Burger)
                .SingleOrDefault(x => x.Id == id);
        }

        public void Save(Order entity)
        {
            _dbContext.Orders .Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Order entity)
        {
            _dbContext.Orders.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Order entity)
        {
            _dbContext.Orders.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
