using HealthOnion.Domain.Core;
using HealthOnion.Domain.Interfaces;
using HealthOnion.Infrastructure.Data;
using HealthOnion.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthcareFullProject.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IPatientRepository repository;
        public HomeController(IPatientRepository repo)
        {
            repository = repo;
        }


        // GET: api/<HomeController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return repository.Patients();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Patient patient  =  repository.Patients().SingleOrDefault(x => x.Id == id);
            if (patient ==  null)
            {
                return BadRequest("There is now patient with this id!");
            }
            return Ok(patient);
        }


        //// POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
            repository.Create(patient);
            repository.Save();
        }





    }
}
