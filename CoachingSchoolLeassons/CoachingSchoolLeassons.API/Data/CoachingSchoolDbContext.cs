using Microsoft.EntityFrameworkCore;
using CoachingSchoolLeassons.API.Models.Domain;

namespace CoachingSchoolLeassons.API.Data
{
    public class CoachingSchoolDbContext : DbContext
    {
        public CoachingSchoolDbContext(DbContextOptions<CoachingSchoolDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
    }
}
