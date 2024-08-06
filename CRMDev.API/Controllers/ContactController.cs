using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRMDev.API.Controllers
{
    [ApiController]
    [Route("api/Contacts")]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public ContactController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContactById(Guid id) {
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateContact()
        {
            return Ok();
        }
        [HttpPost]
        [Route("Note")]
        public IActionResult CreateNote()
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateContact()
        {
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteContact(Guid id) {
            return Ok();
        }
    }
}
