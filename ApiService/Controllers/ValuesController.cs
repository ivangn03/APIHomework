using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTO;
using BLL.Services;

namespace ApiService.Controllers
{
    public class GoodController : ApiController
    {
        IService<GoodDTO> service;
        public GoodController(IService<GoodDTO> service)
        {
            this.service = service;
        }
        // GET api/values
        public IEnumerable<GoodDTO> Get()
        {
            return service.GetAll().ToList();
        }

        // GET api/values/5
        public GoodDTO Get(int id)
        {
            return service.Get(id);
        }

        // POST api/values
        public void Post([FromBody]GoodDTO good)
        {
            service.CreateOrUpdate(good);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]GoodDTO value)
        {
            GoodDTO goodDTO = value;
            service.CreateOrUpdate(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            service.Delete(service.Get(id));
        }
    }
}
