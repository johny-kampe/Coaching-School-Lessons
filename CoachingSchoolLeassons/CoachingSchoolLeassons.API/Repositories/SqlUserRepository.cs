using CoachingSchoolLeassons.API.Data;
using CoachingSchoolLeassons.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoachingSchoolLeassons.API.Interfaces
{
    public class SqlUserRepository : IUserRepository
    {
        private readonly CoachingSchoolDbContext dbContext;

        public SqlUserRepository(CoachingSchoolDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(Guid id)
        {
            return await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Role?> GetUserRoleByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
