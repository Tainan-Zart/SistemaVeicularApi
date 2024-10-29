using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;
public interface IClienteRepository
{
    Task<bool> Salvar(Cliente entity);

    Task<List<Cliente>> BuscarTodos();

    Task<bool> Excluir(BuscaClienteIdDTo model);
    Task<List<Cliente>> BuscarPorId(BuscaClienteIdDTo model);

    
}
