using System.ComponentModel.DataAnnotations;

namespace Solvefy_Assessment.ViewModels
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = default!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = default!;

        public string Role { get; set; }
    }
}
