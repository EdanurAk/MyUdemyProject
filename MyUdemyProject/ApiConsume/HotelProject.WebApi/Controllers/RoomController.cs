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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;//_Roomservice örneklemiş oldum

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]//o Api nin hangi attribute ile çalışcağını bildirmek gerekiyo
        public IActionResult RoomList()//verileri listeleme kısmında herhangi bir parametrem yoksa yani direkt olarak verileri getirmek istiyorsam httpget attribute kullanıyorum.  
        {
            var values = _roomService.TGetList();
            return Ok(values);//ok yazmamızın sebebi hata vermesin diye controller kısmında view dönmemiz gibi
        }
        [HttpPost]//Yeni bir veri ekleme kısmında
        public IActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }

        [HttpDelete("{id}")]//Silme işlemi için kullanılacak
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            _roomService.TDelete(values);
            return Ok();
        }
        [HttpPut]//Güncelleme işlemi için kullanılacak
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]//id ye göre getirme işlemi olacak.Yani dışardan bir id parametresi alacak.
        public IActionResult GetRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            return Ok(values);
        }
    }
}
