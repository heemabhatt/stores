using Microsoft.AspNetCore.Mvc;
using Store.Data.Repositories.Interfaces;
using System;

namespace Store.API.Controllers
{
    [Route("[controller]")]
    public class RestaurantsController:Controller
    {
        private IRestaurantRepository _restaurantRepository;
        public RestaurantsController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        [HttpGet]
        public JsonResult Get()
        {
            try
            {
                var restaurants = _restaurantRepository.GetAllRestaurants();
                return Json(restaurants);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public JsonResult Get(string id)
        {
            try
            {
                var restaurants = _restaurantRepository.GetRestaurant(id);
                return Json(restaurants);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
