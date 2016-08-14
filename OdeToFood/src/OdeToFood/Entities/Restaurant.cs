using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace OdeToFood.Entities
{
    public enum CuisineType
    {
        None,
        Italian ,
        French,
        Indian
    }
    public class Restaurant
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        [Display(Name="Restaurant Name")]
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
