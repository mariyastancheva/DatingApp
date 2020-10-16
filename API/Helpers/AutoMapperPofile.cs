using System.Linq;
using API.DTOs;
using API.Entities;
using API.Extentions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperPofile : Profile
    {
        public AutoMapperPofile()
        {
            CreateMap<AppUser, MemberDto>()
            .ForMember(dest=>dest.PhotoUrl,opt => opt.MapFrom(x=>x.Photos.FirstOrDefault(p=>p.IsMain).Url))
            .ForMember(dest=>dest.Age,opt => opt.MapFrom(x=>x.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
        }
    }
}