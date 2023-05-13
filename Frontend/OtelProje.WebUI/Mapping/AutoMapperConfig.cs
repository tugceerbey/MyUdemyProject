using AutoMapper;
using OtelProje.EntityLayer1.Concrete;
using OtelProje.WebUI.Dtos.LoginDto;
using OtelProje.WebUI.Dtos.RegisterDto;
using OtelProje.WebUI.Dtos.ServiceDto;

namespace OtelProje.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
         {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap();
        }
    }
}
