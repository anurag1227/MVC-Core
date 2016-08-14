using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Models.Restaurant { Id=1,Name="Papa John's"},
                new Models.Restaurant { Id=2,Name="Biryani City"},
                new Models.Restaurant { Id=3,Name="Domino's"},
                new Models.Restaurant { Id=4,Name="Pizza Hut"},
                new Models.Restaurant { Id=5,Name="Pind Balluchi"},
                new Models.Restaurant { Id=6,Name="Kwality"}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
