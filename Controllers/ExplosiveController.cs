using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace explosive_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosiveController : ControllerBase
    {
        [HttpGet("{s}")]

        public ActionResult<string> Explosion(string number)
        {
            return string.Join("", number.Select(number => new string(number, int.Parse(number.ToString()))));
        }
    }
}