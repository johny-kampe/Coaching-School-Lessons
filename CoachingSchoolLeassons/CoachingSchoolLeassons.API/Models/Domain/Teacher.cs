using System.ComponentModel.DataAnnotations.Schema;

namespace CoachingSchoolLeassons.API.Models.Domain
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
