using Store_BaseEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_BaseEntity.Services
{
    public interface IStoreData
    {
        List<Store> GetAllStores();
        Store GetStoreById(int id);
        List<Store> GetStoreByAddress(string address);
    }
}
