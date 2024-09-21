using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces;
public interface IClienteRepository
{
    Task<bool> Created(Cliente entity);
}
