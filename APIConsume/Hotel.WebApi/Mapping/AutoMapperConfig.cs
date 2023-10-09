
//DTO' lar ile Entityleri birbirine bağladığımız yer.

using AutoMapper;
using Hotel.DTOLayer.Dtos.RoomDto;
using Hotel.EntityLayer.Concrete;

namespace Hotel.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<RoomUpdateDto, Room>().ReverseMap();
           
        }
    }
}
