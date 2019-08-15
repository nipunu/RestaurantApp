using Restaurant.BusinessModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant.DataModel
{
    public interface IRestaurantData
    {
        IEnumerable<MyRestaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<MyRestaurant> myRestaurants;

        public InMemoryRestaurantData() {
            myRestaurants = new List<MyRestaurant>()
            {
                new MyRestaurant {Id=1, Name="My Pizza", Location="Colombo", Cuisine=cuisineType.Italian},
                new MyRestaurant {Id=2, Name="Yaal", Location="Nuwara Eliya", Cuisine=cuisineType.Indian},
                new MyRestaurant {Id=3, Name="Max Food", Location="Kandy", Cuisine=cuisineType.Mexian},
            };
        }
        public IEnumerable<MyRestaurant> GetAll()
        {
            return from rest in myRestaurants
                   orderby rest.Name
                   select rest;

        }
    }
}
