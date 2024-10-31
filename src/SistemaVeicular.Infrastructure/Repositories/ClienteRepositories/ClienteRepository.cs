using Microsoft.EntityFrameworkCore;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
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

    public async Task<bool> Salvar(Cliente entity)
    {
        try
        {
            if (entity.Id == 0)
            {
                await _context.AddAsync(entity);
            }
            else
            {
                var clienteExistente = await _context.Cliente
                    .Include(c => c.Endereco)
                    .FirstOrDefaultAsync(c => c.Id == entity.Id);

                clienteExistente.Nome = entity.Nome;
                clienteExistente.Sobrenome = entity.Sobrenome;
                clienteExistente.Telefone = entity.Telefone;
                clienteExistente.CPF = entity.CPF;
                clienteExistente.Email = entity.Email;
                clienteExistente.DataNascimento = entity.DataNascimento;
                clienteExistente.Endereco = entity.Endereco;
                
                _context.Cliente.Update(clienteExistente);
            }
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {

            throw new Exception(ex.InnerException?.Message ?? ex.Message);
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

    public async Task<bool> Excluir(List<long> id)
    {
        try
        {

            var clientes = await _context.Cliente
                .Include(cliente => cliente.Endereco)
                .Where(cliente => id.Contains(cliente.Id))
                .ToListAsync();

            foreach (var cliente in clientes)
            {

                _context.Endereco.Remove(cliente.Endereco);

            }

            _context.Cliente.RemoveRange(clientes);
            await _context.SaveChangesAsync();
            return true;
        }
        catch 
        {
            return false;
        }
    }
}




