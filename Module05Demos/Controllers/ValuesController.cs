using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Module05Demos.Controllers
{
    public class ValuesController : ApiController
    {
        List<string> names;
        public ValuesController()
        {
            names = new List<string> { "Alice", "Bob", "Charlie" };
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return names;
        }
        // GET api/values/5
        public string Get(int id)
        {
            if (id < names.Count)
                return string.Format("Name at index {0} is {1}", id, names[id]);
            else
                return "Index out of range!";
        }
        // POST api/values
        public string Post([FromBody]string value)
        {
            names.Add(value);
            Thread.Sleep(3000);
            return "I inserted: " + value;
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
}
