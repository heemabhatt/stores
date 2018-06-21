using System.Collections.Generic;
using System.Linq;
using Store_BaseEntity.Models;

namespace Store_BaseEntity.Services
{
    public class StoreData : IStoreData
    {
        List<Store> _stores;
        /// <summary>
        /// controller constructor
        /// </summary>
        public StoreData()
        {
            _stores = new List<Store> {
                new Store{Id=1,Name="Subway Baltimore",Address="Baltimore"},
                new Store{Id=2,Name="Subway EC", Address="Ellicott City"}
            };
        }
        /// <summary>
        /// GetAll stores method
        /// </summary>
        /// <returns></returns>
        public List<Store> GetAllStores()
        {
            return _stores;
        }
        /// <summary>
        /// Get stores by store address
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public List<Store> GetStoreByAddress(string address)
        {
            if (address != null)
            {
                return _stores.Where(s => s.Address.Contains(address)).ToList();
            }
            else {
                return _stores;
            }
        }
        
        /// <summary>
        /// Get stores by store id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Store GetStoreById(int id)
        {
            return _stores.FirstOrDefault(s => s.Id == id);
        }
    }
}
