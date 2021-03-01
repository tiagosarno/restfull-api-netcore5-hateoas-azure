using harmonicus.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using harmonicus.Data.VO;

namespace harmonicus.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PsychologistController : ControllerBase
    {
        private readonly ILogger<PsychologistController> _logger;
        private IPsychologistBusiness _psychologistBusiness;

        public PsychologistController(ILogger<PsychologistController> logger, IPsychologistBusiness psychologistBusiness)
        {
            _logger = logger;
            _psychologistBusiness = psychologistBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {            
            return Ok(_psychologistBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var psychologist = _psychologistBusiness.FindById(id);
            if (psychologist == null) return NotFound();
            return Ok(psychologist);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PsychologistVO psychologist)
        {
            if (psychologist == null) return BadRequest();
            return Ok(_psychologistBusiness.Create(psychologist));
        }

        [HttpPut]
        public IActionResult Put([FromBody] PsychologistVO psychologist)
        {
            if (psychologist == null) return BadRequest();
            return Ok(_psychologistBusiness.Update(psychologist));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _psychologistBusiness.Delete(id);
            return NoContent();
        }
    }
}
