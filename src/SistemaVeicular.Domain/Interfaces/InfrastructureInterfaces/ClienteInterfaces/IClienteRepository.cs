using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;
public interface IClienteRepository
{
    Task<bool> Created(Cliente entity);
}
