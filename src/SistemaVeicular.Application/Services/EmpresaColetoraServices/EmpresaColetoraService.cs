using AutoMapper;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Dtos.EmpresaColetoraDtos;
using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EmpresaColetoraInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.EmpresaColetoraInterfaces;

namespace SistemaVeicular.Application.Services.EmpresaColetoraServices
{
    public class EmpresaColetoraService : IEmpresaColetoraService
    {
        private readonly IMapper _mapper;
        private readonly IEmpresaColetoraRepository _empresaColetoraRepositoy;


        public EmpresaColetoraService(IEmpresaColetoraRepository empresaColetoraRepositoy, IMapper mapper)
        {
            _mapper = mapper;
            _empresaColetoraRepositoy = empresaColetoraRepositoy;
        }

        public async Task<bool> Cadastrar(EmpresaColetoraDto model)
        {
            var empresaColetora = _mapper.Map<EmpresaColetora>(model);
            return await _empresaColetoraRepositoy.Salvar(empresaColetora);
        }

        public async Task<List<RetornoEmpresaColetoraDto>> BuscarPorId(BuscaEmpresaColetoraidDto model)
        {
            var empresaColetora = await _empresaColetoraRepositoy.BuscarPorId(model);
            var response = _mapper.Map<List<RetornoEmpresaColetoraDto>>(empresaColetora);
            return response;
        }

        public async Task<List<RetornoEmpresaColetoraDto>> BuscarTodos()
        {
            var clientes = await _empresaColetoraRepositoy.BuscarTodos();
            var response = _mapper.Map<List<RetornoEmpresaColetoraDto>>(clientes);
            return response;
        }

    }
}
