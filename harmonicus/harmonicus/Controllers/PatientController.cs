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
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;
        private IPatientBusiness _patientBusiness;

        public PatientController(ILogger<PatientController> logger, IPatientBusiness patientBusiness)
        {
            _logger = logger;
            _patientBusiness = patientBusiness;
        }

        [HttpGet("{sortDirection}/{pageSize}/{page}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(
            [FromQuery] string name,
            string sortDirection,
            int pageSize,
            int page)
        {            
            return Ok(_patientBusiness.FindWithPagedSearch(name, sortDirection, pageSize, page));
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var patient = _patientBusiness.FindById(id);
            if (patient == null) return NotFound();
            return Ok(patient);
        }

        [HttpGet("findByName")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get([FromQuery] string firstName, [FromQuery] string lastName)
        {
            var patient = _patientBusiness.FindByName(firstName, lastName);
            if (patient == null) return NotFound();
            return Ok(patient);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] PatientVO patient)
        {
            if (patient == null) return BadRequest();
            return Ok(_patientBusiness.Create(patient));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] PatientVO patient)
        {
            if (patient == null) return BadRequest();
            return Ok(_patientBusiness.Update(patient));
        }

        [HttpPatch("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Patch(long id)
        {
            var patient = _patientBusiness.Disable(id);
            return Ok(patient);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _patientBusiness.Delete(id);
            return NoContent();
        }
    }
}
