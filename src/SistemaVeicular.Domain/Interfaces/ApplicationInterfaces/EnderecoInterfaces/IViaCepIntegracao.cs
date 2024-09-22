using SistemaVeicular.Domain.Dtos.EnderecoDtos;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EnderecoInterfaces;
public interface IViaCepIntegracao
{
    Task<EnderecoViaCepDto> ObterDadosViaCep(string cep);
}
