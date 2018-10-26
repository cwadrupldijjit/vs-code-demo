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
        
        // GET api/message
        [HttpGet]
        [Route("/api/message2")]
        public ActionResult<string> GetSecondMessage()
        {
            return _messageService.GetSecondMessage();
        }
    }
}
