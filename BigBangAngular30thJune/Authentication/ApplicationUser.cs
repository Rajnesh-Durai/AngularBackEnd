using Microsoft.AspNetCore.Identity;

namespace BigBangAngular30thJune.Authentication
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string Roles { get; set; } = string.Empty;
    }
}
