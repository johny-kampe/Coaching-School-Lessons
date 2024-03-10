using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoachingSchoolLeassons.API.Models.Domain
{
    public class UserSubject
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }
    }
}
