using Microsoft.AspNetCore.Identity;

namespace Solvefy_Assessment.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsRemember { get; set; }
        public string Role { get; set; }

    }
}
