using BurgerApp.Data.Models;
using BurgerApp.Data.Repositories;
using BurgerApp.Services.Mapper;
using BurgerApp.Services.Models.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Services.Implementation
{
    public class BurgerServices : IBurgerServices
    {
        private readonly IRepository<Burger> repository;

        public BurgerServices(IRepository<Burger> repository)
        {
            this.repository = repository;
        }

        public void Create(CreateBurgerModel createBurgerModel)
        {
            repository.Save(new Burger(createBurgerModel.Name, createBurgerModel.Price)
            {
                IsVegan = createBurgerModel.IsVegan,
                IsVegeterian = createBurgerModel.IsVegeterian,
                HasFries = createBurgerModel.HasFries
            });
        }

        public void Delete(int id)
        {
            var burger = repository.GetById(id);
            if (burger == null)
            {
                throw new Exception();
            }

            repository.Delete(burger);
        }

        public IEnumerable<BurgerModel> GetAll()
        {
            IEnumerable<Burger> burger = repository.GetAll();
            return burger.Select(x => x.ToModel());
        }

        public BurgerDetailsModel GetById(int id)
        {
            Burger? burgers = repository.GetById(id);
            if (burgers == null)
            {
                throw new Exception("");
            }

            return burgers.ToDetailsModel();
        }

        public BurgerModel Update(BurgerModel burgerModel)
        {
            Burger? burger = repository.GetById(burgerModel.Id);
            {
                if (burger == null)
                {
                    throw new Exception("");
                }

                burger.Name = burgerModel.Name;
                burger.Price = burgerModel.Price;
                burger.IsVegeterian = burgerModel.IsVegeterian;
                burger.IsVegan = burgerModel.IsVegan;
                burger.HasFries = burgerModel.HasFries;

                repository.Update(burger);
                return burger.ToModel();
            }
        }
    }
}
