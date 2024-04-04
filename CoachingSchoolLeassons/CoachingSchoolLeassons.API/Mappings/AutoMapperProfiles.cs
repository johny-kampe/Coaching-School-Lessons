using AutoMapper;
using CoachingSchoolLeassons.API.Models.Domain;
using CoachingSchoolLeassons.API.Models.DTO;

namespace CoachingSchoolLeassons.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
