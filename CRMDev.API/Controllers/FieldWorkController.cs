using CRMDev.Application.Commands.CreateFieldWorkCommand;
using CRMDev.Application.Commands.DeleteFieldWorkCommand;
using CRMDev.Application.Commands.UpdateFieldWorkCommand;
using CRMDev.Application.Queries.GetAllFieldWork;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CRMDev.API.Controllers
{
    [ApiController]
    [Route("api/FieldWork")]
    public class FieldWorkController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FieldWorkController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //retirar o FromBody 
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Query = new GetAllFieldWorkQuery();

            var Fields = await _mediator.Send(Query);

            return Ok(Fields);
        }
        //[HttpGet("{id}")]
        //public IActionResult Get()
        //{
        //    return Ok();
        //}
        [HttpPost]
        public async Task<IActionResult> CreateFieldWork(CreateFieldWorkCommand command) {
            var FieldWorkId = await _mediator.Send(command);

            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFieldWork(UpdateFieldWorkCommand command)
        {
            //command.Id = id;

            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFieldWork(Guid id)
        {
            var command = new DeleteFieldWorkCommand(id);

            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
        
            return Ok();

        }
    }
}
