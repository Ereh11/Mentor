namespace Domain.Entities;

public class CompanyWorkIn : BaseEntity<Guid>
{
    public string? Name { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? Industry { get; set; }
    public string? WebsiteUrl { get; set; }
    public DateTime StartWork { get; set; }
    public DateTime? EndWork { get; set; }
    public bool IsCurrentlyWorking { get; set; }
}
