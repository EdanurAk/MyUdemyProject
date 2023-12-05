using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;//_Aboutservice örneklemiş oldum

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]//o Api nin hangi attribute ile çalışcağını bildirmek gerekiyo
        public IActionResult AboutList()//verileri listeleme kısmında herhangi bir parametrem yoksa yani direkt olarak verileri getirmek istiyorsam httpget attribute kullanıyorum.  
        {
            var values = _aboutService.TGetList();
            return Ok(values);//ok yazmamızın sebebi hata vermesin diye controller kısmında view dönmemiz gibi
        }
        [HttpPost]//Yeni bir veri ekleme kısmında
        public IActionResult AddAbout(About about)
        {
            _aboutService.TInsert(about);
            return Ok();
        }
        [HttpDelete]//Silme işlemi için kullanılacak
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            _aboutService.TDelete(values);
            return Ok();
        }
        [HttpPut]//Güncelleme işlemi için kullanılacak
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return Ok();
        }
        [HttpGet("{id}")]//id ye göre getirme işlemi olacak.Yani dışardan bir id parametresi alacak.
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetByID(id);
            return Ok(values);
        }
    }
}
