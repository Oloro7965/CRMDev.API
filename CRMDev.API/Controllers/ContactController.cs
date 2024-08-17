using CRMDev.Application.Commands.CreateContactCommand;
using CRMDev.Application.Commands.CreateNoteCommand;
using CRMDev.Application.Commands.DeleteContactCommand;
using CRMDev.Application.Commands.UpdateContactCommand;
using CRMDev.Application.Queries.GetAllContacts;
using CRMDev.Application.Queries.GetContact;
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
        public async Task<IActionResult> GetAllContacts()
        {

            var Query = new GetAllContactsQuery();

            var contacts = await _mediator.Send(Query);

            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactById(Guid id) {
            var query = new GetContactQuery(id);

            var contact = await _mediator.Send(query);

            if (!contact.IsSuccess)
            {
                return BadRequest(contact.Message);
            }

            return Ok(contact);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            var ContactId = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetContactById), new { id = ContactId }, command);
        }
        [HttpPost]
        [Route("Note")]
        public async Task<IActionResult> CreateNote(CreateNoteCommand command)
        {
            var NoteId = await _mediator.Send(command);

            return Ok(NoteId);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
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
