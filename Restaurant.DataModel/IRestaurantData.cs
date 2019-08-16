using Restaurant.BusinessModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant.DataModel
{
    public interface IRestaurantData
    {
        //IEnumerable<MyRestaurant> GetAll();
        IEnumerable<MyRestaurant> GetRestaurantsByName(string name);
        MyRestaurant GetById(int id);
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
        //public IEnumerable<MyRestaurant> GetAll()
        //{
        //    return from rest in myRestaurants
        //           orderby rest.Name
        //           select rest;

        //}

        public IEnumerable<MyRestaurant> GetRestaurantsByName(string name = null)
        {
            return from rest in myRestaurants
                   where string.IsNullOrEmpty(name) || rest.Name.StartsWith(name)
                   orderby rest.Name
                   select rest;

        }

        public MyRestaurant GetById(int id) {
            return myRestaurants.SingleOrDefault(rest => rest.Id == id);
        }
    }
}
