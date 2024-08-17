using CRMDev.Application.Commands.CreateOpportunityCommand;
using CRMDev.Application.Commands.DeleteFieldWorkCommand;
using CRMDev.Application.Commands.UpdateOpportunityCommand;
using CRMDev.Application.Commands.UpdateStageCommand;
using CRMDev.Application.Queries.GetAllOpportunity;
using CRMDev.Application.Queries.GetOpportunity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CRMDev.API.Controllers
{
    [ApiController]
    [Route("api/opportunity")]
    public class OpportunityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OpportunityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var Query = new GetAllOpportunityQuery();

            var opportunities = await _mediator.Send(Query);

            return Ok(opportunities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetOpportunityQuery(id);

            var opportunity = await _mediator.Send(query);
            if (!opportunity.IsSuccess)
            {
                return BadRequest(opportunity.Message);
            }
            return Ok(opportunity);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOpportunity(CreateOpportunityCommand command)
        {
            var OpportunityId = await _mediator.Send(command);

            return Ok(OpportunityId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(UpdateOpportunityCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return NoContent();
        }
        [HttpPut("{id}")]
        [Route("opportunityStage")]
        public async Task<IActionResult> UpdateOpportunityStage(UpdateStageCommand command)
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
