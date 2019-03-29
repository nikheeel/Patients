using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    [Route("api/values")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/values/serviceget")]
        [HttpPost]
        public void Service([FromBody] Person person)
        {
            return;
        }

        [HttpPost]
        public void Service()
        {
            return;
        }

        [Route("api/values/serviceget")]
        [HttpGet]
        public void ServiceGet()
        {
            return;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
