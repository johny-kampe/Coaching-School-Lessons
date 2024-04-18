using CoachingSchoolLeassons.API.Interfaces;
using CoachingSchoolLeassons.API.Models.Domain;

namespace CoachingSchoolLeassons.API.Services
{
    public class UsersServices
    {
        private readonly SqlUserRepository sqlUserRepository;

        public UsersServices(SqlUserRepository sqlUserRepository)
        {
            this.sqlUserRepository = sqlUserRepository;
        }
        public async Task<List<User>> GetEveryUser()
        {
            var allUsers = await sqlUserRepository.GetAllUsersAsync();

            if (allUsers.Any())
            {
                return allUsers;
            }

            return new List<User>();
        }

        internal async Task<User?> SpecificUserById(Guid id)
        {
            var specificUser = await sqlUserRepository.GetUserByIdAsync(id);

            if (specificUser != null)
            {
                return specificUser;
            }

            return null;
        }
    }
}
