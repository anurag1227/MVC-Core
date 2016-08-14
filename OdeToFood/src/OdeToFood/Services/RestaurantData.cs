using OdeToFood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        void Add(Restaurant rest);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        private static List<Restaurant> _restaurants;
         static InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Entities.Restaurant { Id=1,Name="Papa John's"},
                new Entities.Restaurant { Id=2,Name="Biryani City"},
                new Entities.Restaurant { Id=3,Name="Domino's"},
                new Entities.Restaurant { Id=4,Name="Pizza Hut"},
                new Entities.Restaurant { Id=5,Name="Pind Balluchi"},
                new Entities.Restaurant { Id=6,Name="Kwality"}
            };
        }

        public Restaurant Get(int id)
        {
           return _restaurants.FirstOrDefault(r=>r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }

        public void Add(Restaurant rest)
        {
            rest.Id = _restaurants.Max(p => p.Id) + 1;
            _restaurants.Add(rest);
        }
    }
}
