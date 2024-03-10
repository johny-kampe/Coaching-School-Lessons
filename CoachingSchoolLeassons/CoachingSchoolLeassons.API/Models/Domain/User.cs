using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoachingSchoolLeassons.API.Models.Domain
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }
    }
}
