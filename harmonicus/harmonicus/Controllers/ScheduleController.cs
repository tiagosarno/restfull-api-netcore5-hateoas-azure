using harmonicus.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using harmonicus.Data.VO;
using harmonicus.Hypermedia.Filters;
using Microsoft.AspNetCore.Authorization;

namespace harmonicus.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
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
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {            
            return Ok(_scheduleBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var schedule = _scheduleBusiness.FindById(id);
            if (schedule == null) return NotFound();
            return Ok(schedule);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] ScheduleVO schedule)
        {
            if (schedule == null) return BadRequest();
            return Ok(_scheduleBusiness.Create(schedule));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] ScheduleVO schedule)
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
