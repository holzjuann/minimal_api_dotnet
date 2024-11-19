namespace minimal_api.src.Domain.DTOs
{
    public class LoginDTO
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
