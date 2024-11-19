using minimal_api.src.Domain.DTOs;
using minimal_api.src.Domain.Entities;

namespace minimal_api.src.Domain.Interfaces
{
    public interface IAdmService
    {
        Adm? Login(LoginDTO loginDTO);
    }
}
