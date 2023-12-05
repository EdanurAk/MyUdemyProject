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
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;//_Subscribeservice örneklemiş oldum

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]//o Api nin hangi attribute ile çalışcağını bildirmek gerekiyo
        public IActionResult SubscribeList()//verileri listeleme kısmında herhangi bir parametrem yoksa yani direkt olarak verileri getirmek istiyorsam httpget attribute kullanıyorum.  
        {
            var values = _subscribeService.TGetList();
            return Ok(values);//ok yazmamızın sebebi hata vermesin diye controller kısmında view dönmemiz gibi
        }
        [HttpPost]//Yeni bir veri ekleme kısmında
        public IActionResult AddSubscribe(Subscribe subscribe)
        {
            _subscribeService.TInsert(subscribe);
            return Ok();
        }
        [HttpDelete]//Silme işlemi için kullanılacak
        public IActionResult DeleteSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            _subscribeService.TDelete(values);
            return Ok();
        }
        [HttpPut]//Güncelleme işlemi için kullanılacak
        public IActionResult UpdateSubscribe(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }
        [HttpGet("{id}")]//id ye göre getirme işlemi olacak.Yani dışardan bir id parametresi alacak.
        public IActionResult GetSubscribe(int id)
        {
            var values = _subscribeService.TGetByID(id);
            return Ok(values);
        }
    }
}
