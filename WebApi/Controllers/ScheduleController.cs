using Application.Schedulers.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class ScheduleController : ApiControllerBase
    {


        private readonly ILogger<ScheduleController> _logger;

        public ScheduleController(ILogger<ScheduleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public async Task<IActionResult> Get()
        {

            var list = await Mediator.Send(new GetAllSchedulesQuery());
            return Ok(list);
        }
    }
}