namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        public string Username { get; set; }

        // [Required]
        // [StringLength(8, MinimumLength  = 4, ErrorMessage = "You must specify password length between 4 and 8")]
        public string Password { get; set; }
    }
}