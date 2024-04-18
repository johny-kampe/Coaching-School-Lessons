using CoachingSchoolLeassons.API.Models.Domain;

namespace CoachingSchoolLeassons.API.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAllRolesAsync();
        Task<Role?> GetRoleByIdAsync(Guid id);
    }
}
