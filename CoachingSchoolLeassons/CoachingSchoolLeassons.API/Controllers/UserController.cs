using CoachingSchoolLeassons.API.Data;
using CoachingSchoolLeassons.API.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CoachingSchoolLeassons.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly CoachingSchoolDbContext dbContext;

        public UserController(CoachingSchoolDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet(Name = "GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            //var regionsDomain = await regionRepository.GetAllAsync();

            //var regionsDto = mapper.Map<List<RegionDto>>(regionsDomain);

            return Ok();
        }
    }
}