using System.ComponentModel.DataAnnotations;

namespace BigBangAngular30thJune.Authentication
{
    public class ChangePasswordModel
    {
        [Required]
        public string Username { get; set; }=string.Empty;
        [Required]
        public string CurrentPassword { get; set; }= string.Empty;
        [Required]
        public string NewPassword { get; set; } = string.Empty;
        [Required]
        [Compare("NewPassword")]
        public string ConfirmNewPassword { get; set; } = string.Empty;
    }
}
