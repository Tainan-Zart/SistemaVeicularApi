using SistemaVeicular.Domain.Dtos.ClienteDtos;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.ClienteInterfaces;
public interface IClienteService
{
    Task<bool> Cadastrar(ClienteDto model);
}
