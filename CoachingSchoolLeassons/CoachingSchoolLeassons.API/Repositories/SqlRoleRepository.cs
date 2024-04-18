using CoachingSchoolLeassons.API.Data;
using CoachingSchoolLeassons.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoachingSchoolLeassons.API.Interfaces
{
    public class SqlRoleRepository : IRoleRepository
    {
        private readonly CoachingSchoolDbContext dbContext;

        public SqlRoleRepository(CoachingSchoolDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Role>> GetAllRolesAsync()
        {
            return await dbContext.Roles.ToListAsync();
        }

        public async Task<Role?> GetRoleByIdAsync(Guid id)
        {
            return await dbContext.Roles.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
