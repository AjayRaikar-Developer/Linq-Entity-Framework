using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Linq;
using Linq.Interface;
using LINQ.EntitiesModels;
using LINQ.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Linq.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public class LinqController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<LinqController> _logger;
        private ILinq _LinqInterface;

        public LinqController(ILinq linqInterface, ILogger<LinqController> logger)
        {
            _logger = logger;
            _LinqInterface = linqInterface;
        }

        [HttpPost]
        public IActionResult CreateDepartment(DepartmentDTO department)
        {
            var response = _LinqInterface.CreateDepartment(department);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetDepartment([FromQuery]DepartmentDTO department)
        {
            var response = _LinqInterface.GetDepartment(department);
            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetEmployeebyDepartment([FromQuery] DepartmentDTO department)
        {
            var response = _LinqInterface.GetEmployeebyDepartment(department);
            return Ok(response);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
