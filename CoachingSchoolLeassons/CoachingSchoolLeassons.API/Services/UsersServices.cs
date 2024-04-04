using CoachingSchoolLeassons.API.Data.Repositories;
using CoachingSchoolLeassons.API.Models.Domain;

namespace CoachingSchoolLeassons.API.Services
{
    public class UsersServices
    {
        private readonly SqlUserRepository userRepository;
        private readonly SqlRoleRepository roleRepository;

        public UsersServices(SqlUserRepository userRepository, SqlRoleRepository roleRepository) 
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public async Task<List<User>> GetUsers()
        {
            var usersList = await userRepository.GetAllUsersAsync();

            if(usersList.Any())
            {
                return null;
            }

            return usersList;
        }

        public Role GetUserRoleById(Guid id)
        {
            var user = userRepository.GetUserByIdAsync(id);

            if (user.IsFaulted)
            {
                //throw new Exception There is not user!
            }

            var userRole = roleRepository.GetRoleByIdAsync(user.Result.RoleId);

            if (userRole.IsFaulted)
            {
                return null;
            }

            return userRole.Result;
        }
    }
}
