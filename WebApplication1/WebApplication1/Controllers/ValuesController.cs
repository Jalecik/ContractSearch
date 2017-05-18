using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api")]
    public class ValuesController : ApiController
    {
        [Route("values")]
        [HttpGet]
        public object GetValues()
        {
            var a= new
            {
                name = "ehmed",
                age = 10
            };
            return a;
        }

        // GET api/values/5
        [Route("values/{id}")]
        [HttpGet]
       // [ActionName("getValuesById")]
        public string GetById(int id)
        {
            return "hghgfhtfgh";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
