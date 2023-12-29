using Application.Abstractions.GetF1Team;
using Application.Abstractions.RegisterF1Team;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebCQRSMediatorSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class F1TeamsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public F1TeamsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<F1Team>> GetF1TeamByID(Guid id,string Storetype)
        {
            var F1Team = await _mediator.Send(new GetF1TeamQuery(id, Storetype));
            return F1Team != null ? Ok(F1Team) : NotFound();
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<Guid>> RegisterF1Team([FromBody] F1Team f1Team,string StoreType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var NewF1TeamId = await _mediator.Send(new RegisterF1TeamCommand(f1Team.OfficialTeamName,f1Team.TeamColor,f1Team.TeamPrinciple,f1Team.TeamDrivers, StoreType));
            return  NewF1TeamId;
        }
     
    }
}
