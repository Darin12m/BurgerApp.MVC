using BurgerApp.Services.Models.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Services
{
    public interface IBurgerServices
    {
        public IEnumerable<BurgerModel> GetAll();

        public BurgerDetailsModel GetById (int id);

        public BurgerModel Update (BurgerModel burgerModel);

        public void Create(CreateBurgerModel createBurgerModel);

        public void Delete(int id); 
    }
}
