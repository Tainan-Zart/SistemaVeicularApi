using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SistemaVeicular.Domain.Dtos.EmpresaColetoraDtos;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EmpresaColetoraInterfaces;

namespace SistemaVeicular.Api.Controllers.EmpresaColetora
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaColetoraCotroller : ControllerBase
    {
        private readonly IEmpresaColetoraService _EmpresaColetoraService;

        public EmpresaColetoraCotroller(IEmpresaColetoraService empresaColetoraService)
        {
            _EmpresaColetoraService = empresaColetoraService;
        }

        [HttpPost]
        [Route("cadastro")]
        public async Task<IActionResult> Cadastro(EmpresaColetoraDto model)
        {
            var empresaColetora = await _EmpresaColetoraService.Cadastrar(model);

            return Ok();
        }

        [HttpGet]
        [Route("buscar-por-id")]
        public async Task<IActionResult> BuscarPorId([FromBody] BuscaEmpresaColetoraidDto model)
        {
            var empresaColetora = await _EmpresaColetoraService.BuscarPorId(model);
            return Ok(empresaColetora);
        }

        [HttpGet]
        [Route("buscar-todos")]

        public async Task<IActionResult> BuscarTodos()
        {
            var empresaColetora = await _EmpresaColetoraService.BuscarTodos();

            return Ok(empresaColetora);
        }
    }
}
