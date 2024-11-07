
using AutoMapper;
using IdentityUserTestApi.DTOs;
using Microsoft.AspNetCore.Identity;
namespace _3PL_WMS_Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
			CreateMap<UserForRegistrationDto, IdentityUser>().ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
