using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult TokenCre() //Bu method token oluşturur
        {
            return Ok(new CreateToken().TokenCreate());

        }

        [HttpGet("[action]")]
        public IActionResult AdminCreateToken() //Bu method admin yetkisi için token oluşturur
        {
            return Ok(new CreateToken().TokenCreateAdmin());

        }


        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Wellcome");
        }

        [Authorize(Roles ="Admin , Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Token is succesfully entered");
        }
    }
}
