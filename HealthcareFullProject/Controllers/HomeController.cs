using HealthOnion.Domain.Core;
using HealthOnion.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthcareFullProject.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController : Controller
    {
        private readonly IUserRepository repository;
        public HomeController(IUserRepository repo)
        {
            repository = repo;
        }

        // GET: api/<HomeController>
        [HttpGet]
        public async  Task<IEnumerable<User>> Get()
        {
            return await repository.GetAllUsersAsync();
        }

        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    User patient = repository.Patients().SingleOrDefault(x => x.Id == id);
        //    if (patient == null)
        //    {
        //        return BadRequest("There is now patient with this id!");
        //    }
        //    return Ok(patient);
        //}

        ////// POST api/<HomeController>
        //[HttpPost]
        //public IActionResult Post([FromBody] User patient)
        //{
        //    repository.CreateUser(patient);
        //    repository.Save();
        //    return Ok("Save changess saccessfull!");
        //}
    }
}
