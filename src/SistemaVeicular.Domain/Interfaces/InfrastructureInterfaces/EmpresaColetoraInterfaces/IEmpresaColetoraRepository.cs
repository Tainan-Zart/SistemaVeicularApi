using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Dtos.EmpresaColetoraDtos;
using SistemaVeicular.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.EmpresaColetoraInterfaces
{
    public interface IEmpresaColetoraRepository
    {
        Task<bool> Salvar(EmpresaColetora entity);

        Task<List<EmpresaColetora>> BuscarTodos();

        Task<bool> Excluir(BuscaEmpresaColetoraidDto model);
        Task<List<EmpresaColetora>> BuscarPorId(BuscaEmpresaColetoraidDto model);
    }
}
