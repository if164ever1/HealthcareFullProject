

using HealthcareFullProject.Models;
using HealthcareFullProject.Security;
using HealthOnion.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareFullProject.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class LoginController : Controller
    {
        private readonly IPatientRepository repository;
        public LoginController(IPatientRepository repo)
        {
            repository = repo;
        }

       
    }
}
