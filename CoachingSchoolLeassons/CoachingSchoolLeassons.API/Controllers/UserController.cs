using AutoMapper;
using CoachingSchoolLeassons.API.Models.DTO;
using CoachingSchoolLeassons.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoachingSchoolLeassons.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly UsersServices usersServices;

        public UserController(IMapper mapper, UsersServices usersServices)
        {
            this.mapper = mapper;
            this.usersServices = usersServices;
        }

        [Route("GetAllUsers")]
        [HttpGet]
        public async Task<IActionResult> EverySavedUser()
        {
            var allUsers = await usersServices.GetEveryUser();

            return Ok(allUsers);
        }

        [Route("GetUserById")]
        [HttpGet]
        public async Task<IActionResult> GetSpecificUser(Guid id)
        {
            var specificUser = await usersServices.SpecificUserById(id);

            return Ok(specificUser);
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