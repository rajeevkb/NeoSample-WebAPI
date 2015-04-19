using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using NeoSample.Models;

namespace NeoSample.Controllers
{
    [Route("api/[controller]")]
    public class ZoosController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Zoo> Get()
        {
            var zr = new ZooRepository();
            return zr.Retrieve();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
