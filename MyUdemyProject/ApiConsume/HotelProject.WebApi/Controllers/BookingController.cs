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
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;//_Serviceservice örneklemiş oldum

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]//o Api nin hangi attribute ile çalışcağını bildirmek gerekiyo
        public IActionResult BookingList()//verileri listeleme kısmında herhangi bir parametrem yoksa yani direkt olarak verileri getirmek istiyorsam httpget attribute kullanıyorum.  
        {
            var values = _bookingService.TGetList();
            return Ok(values);//ok yazmamızın sebebi hata vermesin diye controller kısmında view dönmemiz gibi
        }
        [HttpPost]//Yeni bir veri ekleme kısmında
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TInsert(booking);
            return Ok();
        }
        [HttpDelete("{id}")]//Silme işlemi için kullanılacak
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]//Güncelleme işlemi için kullanılacak
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }
        [HttpGet("{id}")]//id ye göre getirme işlemi olacak.Yani dışardan bir id parametresi alacak.
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return Ok(values);
        }
        [HttpPut("aaaaa")]//yukardada httpput olduğu için hata veriyordu bizde parantez içinde action ismini yazdık böyle kullan birden fazla httpput kullanacaksan
        public IActionResult aaaaa(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("bbbb")]//yukardada httpput olduğu için hata veriyordu bizde parantez içinde action ismini yazdık böyle kullan birden fazla httpput kullanacaksan
        public IActionResult bbbb(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
    }
}
