using BurgerApp.Services.Models.Orders;
using BurgerApp.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerApp.Mvc.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrderServices orderService;
        private readonly IBurgerServices _burgerService;
        private readonly ILogger<OrderController> logger;

        public OrderController(IOrderServices orderService, IBurgerServices burgerService, ILogger<OrderController> logger)
        {
            this.orderService = orderService;
            _burgerService = burgerService;
            this.logger = logger;
        }


        // GET: OrderController
        public ActionResult Index()
        {
            var allOrder = orderService.GetAll();
            return View(allOrder);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return View("ViewNotFound");
            }
            try
            {
                var order = orderService.GetById(id);
                return View(order);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");
            }
        }


        // GET: OrderController/Create
        public ActionResult Create()
        {
            ViewBag.Burgers = new SelectList(_burgerService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateOrderModel order)
        {
            orderService.Create(order);
            return RedirectToAction("Index");
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                if (id == null)
                    return View("ViewNotFound");

                var order = orderService.GetById(id);
                return View(order);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");
            }
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(OrderModel model)
        {
            try
            {
                orderService.Update(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");
            }
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            orderService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
