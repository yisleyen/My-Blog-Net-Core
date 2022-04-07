using Jwt.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Login()
        {
            return Created("",new BuildToken().CreateToken());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Dashboard()
        {
            return Ok("Dashboard sayfamıza hoşgeldiniz");
        }
    }
}
