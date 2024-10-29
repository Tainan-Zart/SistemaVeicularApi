using Microsoft.EntityFrameworkCore;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;
using SistemaVeicular.Infrastructure.DataAccess;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SistemaVeicular.Infrastructure.Repositories.ClienteRepositories;
public class ClienteRepository : IClienteRepository
{
    private readonly SistemaVeicularDbContext _context;

    public ClienteRepository(SistemaVeicularDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Salvar(Cliente entity)
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


    public async Task<List<Cliente>> BuscarPorId(BuscaClienteIdDTo model)
    {
        return await _context.Cliente
            .Include(c => c.Endereco)
            .Where(c => model.Id.Contains(c.Id))
            .ToListAsync();
    }

    public async Task<List<Cliente>> BuscarTodos()
    {
        return await _context.Cliente.ToListAsync();
    }

    public async Task<bool> Excluir(BuscaClienteIdDTo model)
    {
        try
        {
            var cliente =  await BuscarPorId(model);
            _context.Remove(cliente);
            _context.SaveChanges();
            return true;

        }
        catch
        {
            return false;
        }
        
    }
}



