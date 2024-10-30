using Microsoft.EntityFrameworkCore;
using SistemaVeicular.Domain.Dtos.EmpresaColetoraDtos;
using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.EmpresaColetoraInterfaces;
using SistemaVeicular.Infrastructure.DataAccess;

namespace SistemaVeicular.Infrastructure.Repositories.EmpresaColetoraRepository
{
    public class EmpresaColetoraRepository : IEmpresaColetoraRepository
    {
        private readonly SistemaVeicularDbContext _context;

        public EmpresaColetoraRepository(SistemaVeicularDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Salvar(EmpresaColetora entity)
        {
            try
            {
                await _context.AddAsync(entity);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.InnerException?.Message);

            }
        }

        public async Task<List<EmpresaColetora>> BuscarPorId(BuscaEmpresaColetoraidDto model)
        {
            return await _context.EmpresaColetora
                .Include(c => c.Endereco)
                .Where(c => model.Id.Contains(c.Id))
                .ToListAsync();
        }

        public async Task<List<EmpresaColetora>> BuscarTodos()
        {
            return await _context.EmpresaColetora.ToListAsync();
        }

        public async Task<bool> Excluir(BuscaEmpresaColetoraidDto model)
        {
            try
            {
                var empresaColetoras = await BuscarPorId(model);
                _context.Remove(empresaColetoras);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
