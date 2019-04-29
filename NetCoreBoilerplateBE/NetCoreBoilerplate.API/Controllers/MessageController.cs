using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreBoilerplate.Contracts;

namespace NetCoreBoilerplate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public MessageController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }
        // GET: api/Message
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var messageTypes = _repoWrapper.MessageType.FindAll();
          // _repoWrapper
            return new string[] { "value1", "value2" };
        }

        // GET: api/Message/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Message
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Message/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
