using Microsoft.AspNetCore.Mvc;
using SistemaVeicular.Domain.Dtos.VeiculoDtos;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.VeiculoInterfaces;

namespace SistemaVeicular.Api.Controllers.Veiculo;
[Route("api/[controller]")]
[ApiController]
public class VeiculoController : ControllerBase
{
    private readonly IIntegracaoApiPlacaRefit _integracaoApiPlacaRefit;

    public VeiculoController(IIntegracaoApiPlacaRefit integracaoApiPlacaRefit)
    {
        _integracaoApiPlacaRefit = integracaoApiPlacaRefit;
    }

    [HttpGet("{placa}")]
    public async Task<ActionResult<VeiculoApiPlacasDtos>> BuscarDadosPorPlaca(string placa)
    {
        var response = await _integracaoApiPlacaRefit.ObterDadosViaPlaca(placa);

        return Ok(response);
    }
}
