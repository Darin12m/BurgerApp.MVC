using BurgerApp.Data.Models;
using BurgerApp.Data.Repositories;
using BurgerApp.Services.Mapper;
using BurgerApp.Services.Models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Services.Implementation
{
    public class LocationServices : ILocationServices
    {
        private readonly IRepository<Location> repository;

        public LocationServices(IRepository<Location> repository)
        {
            this.repository = repository;
        }

        public void Create(CreateLocationModel createLocation)
        {
            repository.Save(new Location(createLocation.Name, createLocation.Address, createLocation.ClosesAt, createLocation.OpensAt)
            {

            });
        }

        public void Delete(int id)
        {
            var location = repository.GetById(id);
            if(location == null)
            {
                throw new Exception();
            }

            repository.Delete(location);

        }

        public IEnumerable<LocationModel> GetAll()
        {
            IEnumerable<Location> locations = repository.GetAll();
            return locations.Select(x => x.ToModel());
        }

        public LocationDetailsModel GetById(int id)
        {
            Location? location = repository.GetById(id);
            if (location == null)
            {
                throw new Exception();
            }

            return location.ToDetailsModel();
        }

        public LocationModel Update(LocationModel locationModel)
        {
            var location = repository.GetById(locationModel.Id);    
            if (location == null)
            {
                throw new Exception();
            }

            location.Name = locationModel.Name;
            location.Address = locationModel.Address;
            location.OpensAt = locationModel.OpensAt;
            location.ClosesAt = locationModel.ClosesAt;

            repository.Update(location);
            return location.ToModel();

        }
    }
}
