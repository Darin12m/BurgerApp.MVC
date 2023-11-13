using BurgerApp.Services.Models.Burgers;
using BurgerApp.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Mvc.Controllers
{
    public class BurgerController : Controller
    {
        private readonly IBurgerServices burgerServices;
        private readonly ILogger<LocationController> logger;

        public BurgerController(IBurgerServices burgerServices, ILogger<LocationController> logger)
        {
            this.burgerServices = burgerServices;
            this.logger = logger;
        }

        // GET: BurgerController
        public ActionResult Index()
        {
            var model = burgerServices.GetAll();
            return View(model);
        }

        // GET: BurgerController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("ViewNotFound");
            }
            try
            {
                var burger = burgerServices.GetById(id.Value);
                return View(burger);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");
            }
        }

        // GET: BurgerController/Create
        public ActionResult Create()
        {
            return View();
        }


        // POST: BurgerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateBurgerModel burger)
        {
            burgerServices.Create(burger);
            return RedirectToAction("Index");
        }

        // GET: BurgerController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return View("ViewNotFound");
            }
            try
            {
                var burger = burgerServices.GetById(id);
                return View(burger);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");

            }
        }

        // POST: BurgerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BurgerModel model)
        {
            try
            {
                var burger = burgerServices.Update(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");
            }
        }



        // POST: BurgerController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            burgerServices.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
