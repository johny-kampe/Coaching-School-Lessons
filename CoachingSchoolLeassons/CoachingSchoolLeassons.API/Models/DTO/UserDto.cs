using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoachingSchoolLeassons.API.Models.DTO
{
    public class UserDto
    {
        [Key]
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }
    }
}
