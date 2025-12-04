namespace Domain.Entities
{
    public class MentorProfile : BaseEntity<Guid>
    {
        public Guid ApplicationUserId { get; set; }
        public string? CurrentJobTitle { get; set; }
        public string? Bio { get; set; }
        public List<string>? Skills { get; set; }

        // Navigation properties
        public ApplicationUser ApplicationUser { get; set; } = null!;
        public ICollection<CompanyWorkIn> CompaniesWorkedIn { get; set; } = new HashSet<CompanyWorkIn>();
    }
}
