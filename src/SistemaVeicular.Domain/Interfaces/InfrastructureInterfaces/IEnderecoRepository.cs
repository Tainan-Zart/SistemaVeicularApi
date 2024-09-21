using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces;
public interface IEnderecoRepository
{ 
     Task<bool> Create(Endereco entity);
}
