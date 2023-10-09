using AutoMapper;
using Hote.WebUI.Dtos.AboutDto;
using Hote.WebUI.Dtos.AppUserDto;
using Hote.WebUI.Dtos.BookingDto;
using Hote.WebUI.Dtos.ContactDto;
using Hote.WebUI.Dtos.CrewDto;
using Hote.WebUI.Dtos.GuestDto;
using Hote.WebUI.Dtos.LoginDto;
using Hote.WebUI.Dtos.MessageCategory;
using Hote.WebUI.Dtos.RegisterDto;
using Hote.WebUI.Dtos.Role;
using Hote.WebUI.Dtos.RoomDto;
using Hote.WebUI.Dtos.SendMessageDto;
using Hote.WebUI.Dtos.ServiceDto;
using Hote.WebUI.Dtos.SubscribeDto;
using Hote.WebUI.Dtos.TeamDto;
using Hote.WebUI.Dtos.WorkLocationDto;
using Hotel.EntityLayer.Concrete;

namespace Hote.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();
            CreateMap<ResultAppUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTeamDto, Crew>().ReverseMap();
            CreateMap<ResultLast4CrewDto, Crew>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
            CreateMap<ResultBookingDto, Booking>().ReverseMap();
            CreateMap<ResultLast6BookingsDto, Booking>().ReverseMap();

            CreateMap<CreateContactDto, Contac>().ReverseMap();
            CreateMap<InboxContactDto, Contac>().ReverseMap();
            CreateMap<ResultMessageContactDto, Contac>().ReverseMap();

            CreateMap<CreateRoomDto, Room>().ReverseMap();
            CreateMap<ResultRoomDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();

            CreateMap<ResultGuestDto, Guest>().ReverseMap();
            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<CreateSendMessageDto, SendMessage>().ReverseMap();
            CreateMap<ResultSendBoxDto, SendMessage>().ReverseMap();
            CreateMap<GetMessageByIDDto, SendMessage>().ReverseMap();

            CreateMap<ResultMessageCategoryDto, MessageCategory>().ReverseMap();

            CreateMap<ResultWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<CreateWorkLocationDto, WorkLocation>().ReverseMap();
            CreateMap<UpdateWorkLocationDto, WorkLocation>().ReverseMap();

            CreateMap<AddRoleDto, AppRole>().ReverseMap();
            CreateMap<UpdateRoleDto, AppRole>().ReverseMap();




            



        }

    }
}
