using BurgerApp.Data.Database;
using BurgerApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Repositories
{
    public class LocationRepository : IRepository<Location>
    {
        private readonly BurgerAppDbContext _dbContext;

        public LocationRepository (BurgerAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        public IEnumerable<Location> GetAll()
        {
            return _dbContext.Locations;
        }

        public Location? GetById(int id)
        {
            return _dbContext.Locations.SingleOrDefault(x  => x.Id == id);
        }

        public void Save(Location entity)
        {
            _dbContext.Locations.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Location entity)
        {
            _dbContext.Locations.Update(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Location entity)
        {
            _dbContext.Locations.Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
