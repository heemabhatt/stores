using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Store_BaseEntity.Services;
using System.Diagnostics;
using System.Security.Claims;

namespace Store_BaseEntity.Controllers
{
    [Route("[controller]/[action]")]
    public class StoresController :Controller
    {
        private IStoreData _storeData;

        public StoresController(IStoreData storeData)
        {
            _storeData = storeData;
        }

       /// <summary>
       /// Gets all stores...
       /// </summary>
       /// <returns></returns>
        [HttpGet]
        public JsonResult Get()
        {
            var stores = _storeData.GetAllStores();
             return Json(stores);
           
        }

        /// <summary>
        /// Gets store by storeId...
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var store = _storeData.GetStoreById(id);
            return Json(store);

        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
