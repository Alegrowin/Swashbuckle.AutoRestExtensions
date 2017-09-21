using System.Collections.Generic;
using System.Web.Http;

namespace Swashbuckle.AutoRestExtensions.NetFramework.Example.Controllers
{
    public class StringController : ApiController
    {
        // GET: api/String
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/String/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/String
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/String/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/String/5
        public void Delete(int id)
        {
        }
    }
}
