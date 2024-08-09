using CRMDev.Application.Commands.CreateOpportunityCommand;
using CRMDev.Application.Commands.DeleteFieldWorkCommand;
using CRMDev.Application.Commands.UpdateOpportunityCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CRMDev.API.Controllers
{
    [ApiController]
    [Route("api/Opportunity")]
    public class OpportunityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OpportunityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOpportunity([FromBody] CreateOpportunityCommand command)
        {
            var OpportunityId = await _mediator.Send(command);

            return Ok(OpportunityId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] UpdateOpportunityCommand command)
        {
            var result = await _mediator.Send(command);
            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
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
