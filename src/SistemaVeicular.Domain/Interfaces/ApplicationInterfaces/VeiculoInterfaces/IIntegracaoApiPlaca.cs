using SistemaVeicular.Domain.Dtos.VeiculoDtos;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.VeiculoInterfaces;
public interface IIntegracaoApiPlaca
{
    Task<VeiculoApiPlacasDtos> ObterDadosApiPlacas(string placa);
}
   