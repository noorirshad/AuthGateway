using Microsoft.AspNetCore.Identity;

namespace AuthGateway.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
