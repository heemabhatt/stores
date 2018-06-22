using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Store.Core.Models;
using Store.Data.Contexts.Interfaces;

namespace Store.Data.Contexts
{
    public class StoreContext:IStoreContext
    {
        public IMongoDatabase _database;

        public IMongoCollection<Restaurant> Restaurants
        {
            get
            {
                return _database.GetCollection<Restaurant>("Restaurants");
            }
        }

        public StoreContext(IOptions<DatabaseSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Value.Database);
            }
        }
    }
}
