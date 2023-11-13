using BurgerApp.Data.Models;
using BurgerApp.Services.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Services.Services
{
    public interface IOrderServices
    {
        public IEnumerable<OrderModel> GetAll();

        public OrderDetailsModel GetById(int id);

        public void Update (OrderModel model);

        public void Delete (int id);

        public void Create (CreateOrderModel createModel);
    }
}
