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
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;//_Serviceservice örneklemiş oldum

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]//o Api nin hangi attribute ile çalışcağını bildirmek gerekiyo
        public IActionResult ServiceList()//verileri listeleme kısmında herhangi bir parametrem yoksa yani direkt olarak verileri getirmek istiyorsam httpget attribute kullanıyorum.  
        {
            var values = _serviceService.TGetList();
            return Ok(values);//ok yazmamızın sebebi hata vermesin diye controller kısmında view dönmemiz gibi
        }
        [HttpPost]//Yeni bir veri ekleme kısmında
        public IActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }
        [HttpDelete("{id}")]//Silme işlemi için kullanılacak
        public IActionResult DeleteService(int id)
        {
            var values = _serviceService.TGetByID(id);
            _serviceService.TDelete(values);
            return Ok();
        }
        [HttpPut]//Güncelleme işlemi için kullanılacak
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }
        [HttpGet("{id}")]//id ye göre getirme işlemi olacak.Yani dışardan bir id parametresi alacak.
        public IActionResult GetService(int id)
        {
            var values = _serviceService.TGetByID(id);
            return Ok(values);
        }
    }
}
