using SistemaVeicular.Domain.Dtos.EnderecoDtos;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces;
public interface IEnderecoService
{
    Task<bool> Creted(EnderecoDto model);
}
