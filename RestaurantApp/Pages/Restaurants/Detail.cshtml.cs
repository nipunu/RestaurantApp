using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Restaurant.BusinessModel;
using Restaurant.DataModel;

namespace RestaurantApp.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private readonly IRestaurantData restaurantData;

        public MyRestaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restaurantData) {
            this.restaurantData = restaurantData;
        }
        public IActionResult OnGet(int restaurantId)
        {           
            Restaurant = restaurantData.GetById(restaurantId);
            //Restaurant.Id = restaurantId;

            if (Restaurant == null) {
                return RedirectToPage("./NotFound");
            }
                return Page();
        }
    }
}