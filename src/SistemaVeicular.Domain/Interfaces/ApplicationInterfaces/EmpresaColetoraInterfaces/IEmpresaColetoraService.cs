using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Dtos.EmpresaColetoraDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EmpresaColetoraInterfaces
{
    public interface IEmpresaColetoraService
    {
        Task<bool> Cadastrar(EmpresaColetoraDto model);

        Task<List<RetornoEmpresaColetoraDto>> BuscarTodos();

        Task<List<RetornoEmpresaColetoraDto>> BuscarPorId(BuscaEmpresaColetoraidDto model);
    }
}
