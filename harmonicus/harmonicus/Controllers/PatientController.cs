﻿using harmonicus.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using harmonicus.Data.VO;

namespace harmonicus.Controllers
{
    [ApiVersion("1")]
    [ApiController]
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

        [HttpGet]
        public IActionResult Get()
        {            
            return Ok(_patientBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var patient = _patientBusiness.FindById(id);
            if (patient == null) return NotFound();
            return Ok(patient);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PatientVO patient)
        {
            if (patient == null) return BadRequest();
            return Ok(_patientBusiness.Create(patient));
        }

        [HttpPut]
        public IActionResult Put([FromBody] PatientVO patient)
        {
            if (patient == null) return BadRequest();
            return Ok(_patientBusiness.Update(patient));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _patientBusiness.Delete(id);
            return NoContent();
        }
    }
}