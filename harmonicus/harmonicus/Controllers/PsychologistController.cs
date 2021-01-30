using harmonicus.Model;
using harmonicus.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harmonicus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PsychologistController : ControllerBase
    {
        private readonly ILogger<PsychologistController> _logger;
        private IPsychologistService _psychologistService;

        public PsychologistController(ILogger<PsychologistController> logger, IPsychologistService psychologistService)
        {
            _logger = logger;
            _psychologistService = psychologistService;
        }

        [HttpGet]
        public IActionResult Get()
        {            
            return Ok(_psychologistService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var psychologist = _psychologistService.FindById(id);
            if (psychologist == null) return NotFound();
            return Ok(psychologist);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Psychologist psychologist)
        {
            if (psychologist == null) return BadRequest();
            return Ok(_psychologistService.Create(psychologist));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Psychologist psychologist)
        {
            if (psychologist == null) return BadRequest();
            return Ok(_psychologistService.Update(psychologist));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _psychologistService.Delete(id);
            return NoContent();
        }
    }
}
