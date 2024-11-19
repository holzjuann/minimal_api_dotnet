using minimal_api.src.Domain.DTOs;
using minimal_api.src.Domain.Entities;
using minimal_api.src.Domain.Interfaces;
using minimal_api.src.Infrastructure.DB;

namespace minimal_api.src.Domain.Services
{
    public class AdmService : IAdmService
    {
        private readonly Context _context;

        public AdmService(Context context)
        {
            _context = context;
        }

        public Adm Login(LoginDTO loginDTO)
        {
            // Verifica se o Email e Password recebidos passados pelo usuario
            // são iguais ao login de algum perfil de Adm presente na base de dados
            var adm = _context.Administradores.Where(a => a.Email == loginDTO.Email && a.Password == loginDTO.Password).FirstOrDefault();
            return adm;
        }
    }
}
