using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces;
using SistemaVeicular.Infrastructure.DataAccess;

namespace SistemaVeicular.Infrastructure.Repositories.EnderecoRepositories;
public class EndereceRepository : IEnderecoRepository
{
    private readonly SistemaVeicularDbContext _context;

    public EndereceRepository(SistemaVeicularDbContext context)
    {
        _context = context;
    }
    public async Task<bool> Create(Endereco entity)
    {
        try
        {
            _context.Add(entity);
            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
