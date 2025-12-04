using Microsoft.AspNetCore.Identity;
namespace Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public string? Bio { get; set; }
        public string? Location { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LinkedInUrl { get; set; }
        public string? GitHubUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUtc { get; set; } = DateTime.UtcNow;
        public bool Hidden { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }
        public bool Locked { get; set; }
        // Navigation properties
        public ICollection<ApplicationUserRole> ApplicationUserRoles { get; set; } = new HashSet<ApplicationUserRole>();
        public MentorProfile? MentorProfile { get; set; }
        public StudentProfile? StudentProfile { get; set; }
        public ICollection<ExternalLogin> ExternalLogins { get; set; } = new HashSet<ExternalLogin>();
    }
}
