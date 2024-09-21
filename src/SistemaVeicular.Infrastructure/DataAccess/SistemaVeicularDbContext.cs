using Microsoft.EntityFrameworkCore;
using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Infrastructure.DataAccess;
public class SistemaVeicularDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<ServicoManutencao> Manutencoes { get; set; }
    public DbSet<TecnicoMecanico> Mecanicos { get; set; }
    public DbSet<Veiculo> Veiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=SistemaVeicular;User Id=postgres;Password=admin;");
    }
}
