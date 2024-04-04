using CoachingSchoolLeassons.API.Models.Domain;

namespace CoachingSchoolLeassons.API.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(Guid id);
        Task<Role?> GetUserRoleByIdAsync(Guid id);
    }
}
