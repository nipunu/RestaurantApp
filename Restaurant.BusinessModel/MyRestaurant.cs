using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.BusinessModel
{
    public class MyRestaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public cuisineType Cuisine { get; set; }
    }
}
