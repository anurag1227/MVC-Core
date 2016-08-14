using Microsoft.AspNetCore.Mvc;
using OdeToFood.Entities;
using OdeToFood.Services;
using OdeToFood.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController:Controller
    {
        private IGreeter _greeter;
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData,IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public ViewResult Index()
        {
            //var model = _restaurantData.GetAll();  
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var rest = new Restaurant();
                rest.Name = model.Name;
                rest.Cuisine = model.Cuisine;
                _restaurantData.Add(rest);
                return RedirectToAction("Details", new { id = rest.Id });
            }
            else
            {
                return View();
            }
        }
    }
}
