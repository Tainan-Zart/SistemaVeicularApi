using SistemaVeicular.Domain.Dtos.ClienteDtos;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces;
public interface IClienteService
{
    Task<bool> Created(ClienteDto model);
}
