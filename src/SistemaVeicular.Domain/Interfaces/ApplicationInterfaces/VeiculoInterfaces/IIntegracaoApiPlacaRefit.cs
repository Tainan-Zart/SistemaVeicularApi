using Refit;
using SistemaVeicular.Domain.Dtos.VeiculoDtos;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.VeiculoInterfaces;
public interface IIntegracaoApiPlacaRefit
{
    [Get("/v2/{placa}")]
    Task<ApiResponse<VeiculoApiPlacasDtos>> ObterDadosViaPlaca(string placa);
}
