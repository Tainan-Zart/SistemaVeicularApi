using SistemaVeicular.Domain.Dtos.VeiculoDtos;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.VeiculoInterfaces;

namespace SistemaVeicular.Application.Services.VeiculoServices;
public class ApiPlacasVeiculoService : IIntegracaoApiPlaca
{
    private readonly IIntegracaoApiPlacaRefit _integracaoApiPlacaRefit;

    public ApiPlacasVeiculoService(IIntegracaoApiPlacaRefit integracaoApiPlacaRefit)
    {
        _integracaoApiPlacaRefit = integracaoApiPlacaRefit;
    }
    public async Task<VeiculoApiPlacasDtos> ObterDadosApiPlacas(string placa)
    {
        try
        {
            var responseData = await _integracaoApiPlacaRefit.ObterDadosViaPlaca(placa);

            if (responseData != null && responseData.IsSuccessStatusCode)
            {
                if (responseData.Content != null)
                {
                    return responseData.Content;
                }
                else
                {
                    throw new Exception("Conteúdo da resposta está vazio.");
                }
            }
            else
            {
                throw new Exception($"Erro ao buscar dados: {responseData?.StatusCode} - {responseData?.Error?.Message}");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Erro na chamada da API: {ex.Message}");
        }
    }
}
