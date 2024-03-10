using Microsoft.EntityFrameworkCore;
using CoachingSchoolLeassons.API.Models.Domain;

namespace CoachingSchoolLeassons.API.Data
{
    public class CoachingSchoolDbContext : DbContext
    {
        public CoachingSchoolDbContext(DbContextOptions<CoachingSchoolDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSubject> UserSubjects { get; set; }

        /// <summary>
        /// Seeding the Database with some data using the EF
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed roles into the database
            var roles = new List<Role>()
            {
                new Role()
                {
                    Id = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee"),
                    Name = "Student"
                },
                new Role()
                {
                    Id = Guid.Parse("7742d5ad-776d-4b67-b32b-dc7c57a6a97c"),
                    Name = "Teacher"
                },
                new Role()
                {
                    Id = Guid.Parse("7744c786-47c5-439d-8c82-4b4b1109f9a9"),
                    Name = "SuperUser"
                }
            };
            modelBuilder.Entity<Role>().HasData(roles);

            // Seed subjects into the database
            var subjects = new List<Subject>
            {
                new Subject
                {
                    Id = Guid.Parse("77a99d53-5a5f-4d5d-a56e-a8da6dfdff66"),
                    Name = "Dutch"
                },
                new Subject
                {
                    Id = Guid.Parse("75c1905d-00ad-401a-94e1-700350d61e63"),
                    Name = "Greek"
                },
                new Subject
                {
                    Id = Guid.Parse("10c1905d-00ad-401a-94e1-700350d61e63"),
                    Name = "Mandarin"
                },
                new Subject
                {
                    Id = Guid.Parse("20c1905d-00ad-401a-94e1-700350d61e63"),
                    Name = "English"
                }   
            };
            modelBuilder.Entity<Subject>().HasData(subjects);

            // Seed users into the database
            var users = new List<User>
            {
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Giannis",
                    LastName = "Kamperakis",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Kalliroi",
                    LastName = "Eustratiou",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Maria",
                    LastName = "Aslanidou",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Giorgos",
                    LastName = "Papadopoulos",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ilias",
                    LastName = "Kazanias",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Stavros",
                    LastName = "Iliiadakis",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Loukas",
                    LastName = "Iliadakis",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Giorgos",
                    LastName = "Armadopoulos",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Giannis",
                    LastName = "Loukiadis",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Aristotelis",
                    LastName = "Sofianos",
                    RoleId = Guid.Parse("c39618f0-9cd5-4d68-88e9-5b2ffe924cee")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Mike",
                    LastName = "van Oheilly",
                    RoleId = Guid.Parse("7742d5ad-776d-4b67-b32b-dc7c57a6a97c")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "July",
                    LastName = "Kennedy",
                    RoleId = Guid.Parse("7742d5ad-776d-4b67-b32b-dc7c57a6a97c")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Thomas",
                    LastName = "Preachon",
                    RoleId = Guid.Parse("7742d5ad-776d-4b67-b32b-dc7c57a6a97c")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Pete",
                    LastName = "Luca",
                    RoleId = Guid.Parse("7742d5ad-776d-4b67-b32b-dc7c57a6a97c")
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Admin",
                    RoleId = Guid.Parse("7744c786-47c5-439d-8c82-4b4b1109f9a9")
                },
            };
            modelBuilder.Entity<User>().HasData(users);

            //// Seed groups into the database
            //var groups = new List<Group>
            //{
            //    new Group
            //    {
            //        Id = Guid.NewGuid(),
            //        SubjectId = Guid.Parse("77a99d53-5a5f-4d5d-a56e-a8da6dfdff66"),
            //        Users = new List<User>
            //            {
            //                users[0],
            //                users[1],
            //                users[2],
            //                users[3],
            //                users[4]
            //            },
            //        DayAndTime = new DateTime(2023, 3, 11, 10, 30, 0)
            //    }
            //};
            //modelBuilder.Entity<User>().HasData(groups);
        }
    }
}
