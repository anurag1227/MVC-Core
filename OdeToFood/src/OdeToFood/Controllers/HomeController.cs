using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController:Controller
    {
        public ObjectResult Index()
        {
            var model = new Restaurant { Id = 1, Name = "Anurag's" };
            return new ObjectResult(model);
        }
    }
}
