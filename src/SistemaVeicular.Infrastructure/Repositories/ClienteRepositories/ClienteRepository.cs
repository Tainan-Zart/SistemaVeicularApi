using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;
using SistemaVeicular.Infrastructure.DataAccess;

namespace SistemaVeicular.Infrastructure.Repositories.ClienteRepositories;
public class ClienteRepository : IClienteRepository
{
    private readonly SistemaVeicularDbContext _context;

    public ClienteRepository(SistemaVeicularDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Created(Cliente entity)
    {
        try
        {
           _context.Add(entity);
           _context.SaveChanges();
           return true;

        }
        catch (Exception ex)
        {
           
            throw new Exception(ex.InnerException?.Message);
            
        }
    }
}



