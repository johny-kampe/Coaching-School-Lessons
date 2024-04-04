using System.ComponentModel.DataAnnotations;

namespace CoachingSchoolLeassons.API.Models.Domain
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
