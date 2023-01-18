using DreamOrbit.Greetings.Component.Interface;
using DreamOrbit.Greetings.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace DreamOrbit.Greetings.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        private readonly IGreetingsComponent _greetingcomponent;

        public GreetingsController(IGreetingsComponent greetingcomponent)
        {
            _greetingcomponent = greetingcomponent;
        }

        [HttpGet]
        public async Task<IActionResult> ProcessBirthdayEmail()
        {

            return Ok(await _greetingcomponent.ProcessBirthdayEmail());
        }






    }
}
