using HealthcareFullProject.Models.Request;
using HealthcareFullProject.Security;
using HealthOnion.Domain.Core;
using HealthOnion.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using System.Threading.Tasks;

namespace Healthcare.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class RegistrationController : Controller
    {
        private readonly IPatientRepository repository;
        public RegistrationController(IPatientRepository repo)
        {
            repository = repo;
        }

        [HttpPost("register")]
        public IActionResult Register (RegistrationRequest registerRequest)
        {
            if (repository.Patients().FirstOrDefault(u => u.Email == registerRequest.Email) != null)
            {
                return BadRequest(new { message = "Login already use" } );
            }

            User userModel = new User
            {
                FirstName = registerRequest.FirstName,
                LastName = registerRequest.LastName,
                Email = registerRequest.Email,
                Password = CustomHash.HashPassword(registerRequest.Password)
            };

            repository.Create(userModel);
            repository.Save();

            return Ok( new { message = "Registration is succesfuly" } );
        }
    }
}
