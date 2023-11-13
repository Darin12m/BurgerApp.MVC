using BurgerApp.Services.Models.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Services
{
    public interface ILocationServices
    {
        public IEnumerable<LocationModel> GetAll();

        public LocationDetailsModel GetById(int id);

        public LocationModel Update(LocationModel locationModel);

        public void Create(CreateLocationModel createLocation);

        public void Delete(int id); 
    }
}
