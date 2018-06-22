using Store.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using Store.Core.Models;
using Store.Data.Contexts.Interfaces;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Store.Data.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly IStoreContext _context;

        public RestaurantRepository(IStoreContext context)
        {
            _context = context;
        }
        public string Test()
        {
            return "Hello World";
        }
        public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            try
            {
                var restaurants = await _context.Restaurants.Find(_ => true).ToListAsync();
                return restaurants;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Restaurant> GetRestaurant(string id)
        {
            try
            {
                var restaurant = await _context.Restaurants.Find(r => r.Id == id).FirstOrDefaultAsync();
                return restaurant;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
