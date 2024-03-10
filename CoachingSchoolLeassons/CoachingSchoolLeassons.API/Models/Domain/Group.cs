using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoachingSchoolLeassons.API.Models.Domain
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Subject")]
        public Guid SubjectId { get; set; }

        public virtual List<User> Users { get; set; }

        public DateTime DayAndTime { get; set; }
    }
}
