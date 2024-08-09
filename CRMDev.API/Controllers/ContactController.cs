using CRMDev.Application.Commands.CreateContactCommand;
using CRMDev.Application.Commands.CreateNoteCommand;
using CRMDev.Application.Commands.DeleteContactCommand;
using CRMDev.Application.Commands.UpdateContactCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CRMDev.API.Controllers
{
    [ApiController]
    [Route("api/Contacts")]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
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
        public async Task<IActionResult> CreateContact([FromBody] CreateContactCommand command)
        {
            var ContactId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetContactById), new { id = ContactId }, command);
        }
        [HttpPost]
        [Route("Note")]
        public async Task<IActionResult> CreateNote([FromBody] CreateNoteCommand command)
        {
            var NoteId = await _mediator.Send(command);

            return Ok(NoteId);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact([FromBody] UpdateContactCommand command)
        {
            //command.Id =id;

            var result = await _mediator.Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(Guid id) {
            var command = new DeleteContactCommand(id);

            var result = await _mediator.Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            //_userService.Delete(id);
            return Ok();
        }
    }
}
