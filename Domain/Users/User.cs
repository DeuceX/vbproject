using Microsoft.AspNetCore.Identity;

namespace Domain.Users
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
