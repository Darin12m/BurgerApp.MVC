using BurgerApp.Services.Models.Locations;
using BurgerApp.Services.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerApp.Mvc.Controllers
{
    public class LocationController : Controller
    {
        private readonly ILocationServices locationService;
        private readonly ILogger<LocationController> logger;

        public LocationController(ILocationServices locationService, ILogger<LocationController> logger)
        {
            this.locationService = locationService;
            this.logger = logger;
        }


        // GET: LocationController
        public ActionResult Index()
        {
            var getLocation = locationService.GetAll();
            return View(getLocation);
        }


        // GET: LocationController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("ViewNotFound");
            }
            try
            {
                var location = locationService.GetById(id.Value);
                return View(location);

            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");
            }
        }

        // GET: LocationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateLocationModel createLocation)
        {
            locationService.Create(createLocation);
            return RedirectToAction("Index");
        }



        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {

            if (id == null)
            {
                return View("ViewNotFound");
            }
            try
            {
                var location = locationService.GetById(id);
                return View(location);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");

            }
        }

        // POST: LocationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LocationModel model)
        {
            try
            {
                var order = locationService.Update(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                return View("NotFoundView");
            }
        }



        // POST: LocationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            locationService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

