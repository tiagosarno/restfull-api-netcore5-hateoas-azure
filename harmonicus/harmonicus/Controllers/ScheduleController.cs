using harmonicus.Model;
using harmonicus.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace harmonicus.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class ScheduleController : ControllerBase
    {
        private readonly ILogger<ScheduleController> _logger;
        private IScheduleBusiness _scheduleBusiness;

        public ScheduleController(ILogger<ScheduleController> logger, IScheduleBusiness scheduleBusiness)
        {
            _logger = logger;
            _scheduleBusiness = scheduleBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {            
            return Ok(_scheduleBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var schedule = _scheduleBusiness.FindById(id);
            if (schedule == null) return NotFound();
            return Ok(schedule);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Schedule schedule)
        {
            if (schedule == null) return BadRequest();
            return Ok(_scheduleBusiness.Create(schedule));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Schedule schedule)
        {
            if (schedule == null) return BadRequest();
            return Ok(_scheduleBusiness.Update(schedule));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _scheduleBusiness.Delete(id);
            return NoContent();
        }
    }
}
