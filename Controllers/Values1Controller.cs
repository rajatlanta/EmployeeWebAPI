using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Values1Controller : ControllerBase
    {
        // GET: api/<Values1Controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Values1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return id.ToString();
        }

        /*  [HttpGet("{id}")]
          public string Test(int id)
          {
              return id.ToString();
          }

          [Route("Sample/Details")]
          [HttpGet("{id}")]
          public string Test1(int id)
          {
              return id.ToString();
          } */

        [Route("Sample/Details")]
        [HttpGet]
        public string Test1()
        {
            return "My Name is Rajkiran";
        }

        
        [Route("Sample/Test2/{id?}/{name?}")]
        
        public string Test2(int id, string name)
        {
            return "My Name is Rajkiran" + id.ToString();
        }

        // POST api/<Values1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Values1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Values1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
