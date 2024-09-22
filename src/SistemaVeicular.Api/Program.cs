using Refit;
using SistemaVeicular.Application.Services.ClienteServices;
using SistemaVeicular.Application.Services.EnderecoServices;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.ClienteInterfaces;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EnderecoInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;
using SistemaVeicular.Infrastructure.DataAccess;
using SistemaVeicular.Infrastructure.Repositories.ClienteRepositories;


namespace SistemaVeicular.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
      
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<SistemaVeicularDbContext>();
        builder.Services.AddHttpClient<ViaCepEnderecoService>();

        #region Injeção Application 

        builder.Services.AddScoped<IClienteService,  ClienteService>();
        builder.Services.AddScoped<IViaCepIntegracao, ViaCepEnderecoService>();
       
        #endregion

        #region Injeção Infrasctructure 

        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

        #endregion

        builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c =>
        {
            c.BaseAddress = new Uri("https://viacep.com.br");
        });

    

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
