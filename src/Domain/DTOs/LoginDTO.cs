namespace minimal_api.src.Domain.DTOs
{
    public class LoginDTO
    {
        // Classe que recebe e email e senha do usuario, e é passada como parâmetro para ferificação de login
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
