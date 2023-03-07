using Application.Schedulers.Commands;
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

        [HttpGet(Name = "Listar agendamentos")]
        public async Task<IActionResult> Get()
        {
            var list = await Mediator.Send(new GetAllSchedulesQuery());
            return Ok(list);
        }

        [HttpPost(Name = "Adicionar agendamento")]
        public async Task<IActionResult> Post([FromBody] CreateScheduleCommand createSchedule)
        {
            var guid = await Mediator.Send(createSchedule);
            return Content(guid.ToString());
        }
    }
}