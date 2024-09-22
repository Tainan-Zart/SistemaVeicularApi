using Refit;
using SistemaVeicular.Domain.Dtos.EnderecoDtos;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EnderecoInterfaces;
public interface IViaCepIntegracaoRefit
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<EnderecoViaCepDto>> ObterDadosViaCep(string cep);
}
