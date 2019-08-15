using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Restaurant.BusinessModel;
using Restaurant.DataModel;

namespace RestaurantApp.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public ListModel(IConfiguration config, IRestaurantData restaurantData) {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public string Message { get; set; }
        public IEnumerable<MyRestaurant> Restaurants { get; set; }


        public void OnGet()
        {
            //Message = "Hello World";
            Message = config["Message"];
            Restaurants = restaurantData.GetAll();
        }
    }
}