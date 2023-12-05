using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult TokenOluştur()
        {
            return Ok(new CreateToken().TokenCreate());//eğer ki ben test action'ın içerisinde gidersem bana bir tane token üretmesi gerekiyo
        }
        [HttpGet("[action]")]
        public IActionResult AdminTokenOluştur()
        {
            var a = new CreateToken().TokenCreateAdmin();
            return Ok(a);//eğer ki ben test action'ın içerisinde gidersem bana bir tane token üretmesi gerekiyo
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Hoşgeldiniz");
        }
        [Authorize(Roles ="Admin,Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Token başarılı bir şekilde giriş yaptı");
        }
    }
}
