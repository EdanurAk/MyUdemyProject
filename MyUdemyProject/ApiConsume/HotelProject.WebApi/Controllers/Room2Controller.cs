using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
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
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;
        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(RoomAddDto roomAddDto)
        {
            if(!ModelState.IsValid)//RoomAddDto sınıfında propertyler için yazdığımız kurallara uygun değilse
            {
                return BadRequest();//olumsuz istek dön tanımladığım hata mesajlarını veriyo
            }
            var values = _mapper.Map<Room>(roomAddDto);//???
            _roomService.TInsert(values);
           
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(UpdateRoomDto updateRoomDto)
        {
            if(!ModelState.IsValid)//doğrulama işlemi geçersizse yani kurallara uygun değilse 
            {
                return BadRequest();//BadRequest içerisinde bizim hata mesajlarımızı yakalıyor
            }
            var values = _mapper.Map<Room>(updateRoomDto);//Room entitysini parametreden gelen değerler için çalıştırcaz
            _roomService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }

    }
}
