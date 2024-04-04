using AutoMapper;
using CoachingSchoolLeassons.API.Interfaces;
using CoachingSchoolLeassons.API.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CoachingSchoolLeassons.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var usersDomain = await userRepository.GetAllUsersAsync();

            return Ok(usersDomain);
        }

        //[HttpGet(Name = "GetUserRole")]
        //public async Task<IActionResult> GetUserRole()
        //{
        //    var usersDomain = await userRepository.GetAllUsersAsync();

        //    var user = await userRepository.GetUserByIdAsync(usersDomain[0].Id);

        //    var userDto = mapper.Map<List<UserDto>>(usersDomain);

        //    return Ok(userDto);
        //}
    }
}