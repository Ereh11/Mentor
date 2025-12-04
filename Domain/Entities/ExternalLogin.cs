using Domain.Enums;

namespace Domain.Entities
{
    public class ExternalLogin : BaseEntity<Guid>
    {
        public LoginProvider LoginProvider { get; set; }
        public string ProviderKey { get; set; } = string.Empty;
    }
}
