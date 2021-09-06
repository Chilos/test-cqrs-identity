using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Notes.Identity.Model
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public string ReturnUrl { get; set; }
    }
}