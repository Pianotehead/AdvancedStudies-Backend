using Microsoft.AspNetCore.Identity;

namespace AdvancedStudies_Backend.Models.Domain
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool ReceiveEmails { get; set; }
        public string? CurrentAddress { get; set; }
        public string? Gender { get; set; }
        public string? About { get; set; }
        public string? WebsiteLink { get; set; }
        public string? TwitterLink { get; set; }
        public string? FacebookLink { get; set; }
        public string? LinkedinLink { get; set; }
        public string? Experience { get; set; }
        public string? Education { get; set; }
    }
}
