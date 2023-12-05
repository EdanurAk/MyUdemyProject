using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            //Bu mapleme işlemi sayesinde napıyo olcaz biz dto sınıfında geçmiş olduğumuz propertylerimizle entity katmanında yer alan sınıflarımızdaki propertylerimiz birbiriyle eşleşmiş olcak    
            CreateMap<RoomAddDto, Room>();//RoomAddDto ile Room sınıfını birleştir.
            CreateMap<Room, RoomAddDto>();//Room sınıfı da RoomAddDto sınıfı ile birleştirilsin. Tam tersini de yapıyoruz.

            CreateMap<UpdateRoomDto, Room>().ReverseMap();//ReverseMap sayesinde CreateMap<Room, RoomAddDto>(); yazmama gerek kalmıyo
        }
    }
}
