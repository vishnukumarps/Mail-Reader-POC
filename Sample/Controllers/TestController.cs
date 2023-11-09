

using Microsoft.AspNetCore.Mvc;
using Sample.ExceptionFilters;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace Sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(CustomExceptionFilter))]
    public class TestController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpGet]
        //[CustomAttribute("Admin","TeamAdmin")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
       
        public string Get(int id)
        {
            throw new NotImplementedException();
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
