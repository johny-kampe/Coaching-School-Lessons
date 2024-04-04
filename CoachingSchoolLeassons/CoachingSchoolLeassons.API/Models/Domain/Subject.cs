using System.ComponentModel.DataAnnotations;

namespace CoachingSchoolLeassons.API.Models.Domain
{
    public class Subject
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
    }
}
