using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PetProject.Core.Domain.Identity
{
    public class AppRole : IdentityRole<Guid>
    {
        [Required]
        [MaxLength(200)]
        public required string DisplayName { get; set; }
    }
}
