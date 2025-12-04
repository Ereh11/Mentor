namespace Domain.Entities
{
    public class StudentProfile : BaseEntity<Guid>
    {
        public Guid ApplicationUserId { get; set; }
        public string? University { get; set; }
        public string? Major { get; set; }
        public int? YearOfStudy { get; set; }
        public string? Bio { get; set; }
        public List<string>? Interests { get; set; }
        // Navigation properties
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
