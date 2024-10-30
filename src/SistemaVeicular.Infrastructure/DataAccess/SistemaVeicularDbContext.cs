using Microsoft.EntityFrameworkCore;
using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Infrastructure.DataAccess;
public class SistemaVeicularDbContext : DbContext
{
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<Endereco> Endereco { get; set; }
    public DbSet<ServicoManutencao> Manutencoe { get; set; }
    public DbSet<TecnicoMecanico> Mecanico { get; set; }
    public DbSet<Veiculo> Veiculo { get; set; }
    public DbSet<EmpresaColetora> EmpresaColetora {get; set; }
    public DbSet<Notificacao> Notificacao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=SistemaVeicular;User Id=admin;Password=postgres;");
        optionsBuilder.UseNpgsql("server=localhost;username=postgres;database=SistemaVeicular;Password=postgres");
    }
}

