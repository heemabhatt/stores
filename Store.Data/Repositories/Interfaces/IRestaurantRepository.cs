using System;
using System.Collections.Generic;
using Store.Core.Models;
using System.Threading.Tasks;

namespace Store.Data.Repositories.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant>> GetAllRestaurants();
        Task<Restaurant> GetRestaurant(string id);
        string Test();
    }
}
