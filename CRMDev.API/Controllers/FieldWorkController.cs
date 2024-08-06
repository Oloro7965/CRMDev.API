using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CRMDev.API.Controllers
{
    [ApiController]
    [Route("api/FieldWork")]
    public class FieldWorkController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public FieldWorkController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }
        //[HttpGet("{id}")]
        //public IActionResult Get()
        //{
        //    return Ok();
        //}
        [HttpPost]
        public IActionResult CreateFieldWork() {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateFieldWork()
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFieldWork()
        {
            return Ok();
        }
    }
}
