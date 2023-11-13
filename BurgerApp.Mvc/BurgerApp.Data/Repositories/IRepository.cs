using BurgerApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Data.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {

        public IEnumerable<T> GetAll();

        public T? GetById(int id);

        public void Update(T entity);

        public void Save(T entity);

        public void Delete(T entity);




    }
}
