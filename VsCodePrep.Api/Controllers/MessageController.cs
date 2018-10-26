using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VsCodePrep.Services;

namespace VsCodePrep.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        public IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }
        
        // GET api/message
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _messageService.GetMessage();
        }

        // GET api/message/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/message
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/message/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/message/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
