using MongoDB.Driver;
using Store.Core.Models;

namespace Store.Data.Contexts.Interfaces
{
    public interface IStoreContext
    {
        IMongoCollection<Restaurant> Restaurants { get; }
    }
}
