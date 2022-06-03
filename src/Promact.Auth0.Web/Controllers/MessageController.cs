using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Promact.Auth0.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : Auth0ControllerBase
    {
        // GET: api/<MessageController>
        [HttpGet]
        [Authorize("read:message")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MessageController>/5
        [HttpGet("{id}")]
        [Authorize("read:message")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MessageController>
        [HttpPost]
        [Authorize("write:message")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MessageController>/5
        [HttpPut("{id}")]
        [Authorize("write:message")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        [Authorize("write:message")]
        public void Delete(int id)
        {
        }
    }
}
