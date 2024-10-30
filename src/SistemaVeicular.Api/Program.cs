using AutoMapper;
using Refit;
using SistemaVeicular.Application.Services.ClienteServices;
using SistemaVeicular.Application.Services.EmpresaColetoraServices;
using SistemaVeicular.Application.Services.EnderecoServices;
using SistemaVeicular.Application.Services.VeiculoServices;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.ClienteInterfaces;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EmpresaColetoraInterfaces;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EnderecoInterfaces;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.VeiculoInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.EmpresaColetoraInterfaces;
using SistemaVeicular.Infrastructure.DataAccess;
using SistemaVeicular.Infrastructure.Repositories.ClienteRepositories;
using SistemaVeicular.Infrastructure.Repositories.EmpresaColetoraRepository;


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

        builder.Services.AddScoped<IEmpresaColetoraService, EmpresaColetoraService>();
        builder.Services.AddScoped<IClienteService,  ClienteService>();
        builder.Services.AddScoped<IViaCepIntegracao, ViaCepEnderecoService>();
        builder.Services.AddScoped<IIntegracaoApiPlaca, ApiPlacasVeiculoService>();


        #endregion

        #region Injeção Infrasctructure 

        builder.Services.AddScoped<IEmpresaColetoraRepository, EmpresaColetoraRepository>();
        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

        #endregion

        builder.Services.AddRefitClient<IViaCepIntegracaoRefit>().ConfigureHttpClient(c =>
        {
            c.BaseAddress = new Uri("https://viacep.com.br");
        });

        builder.Services.AddRefitClient<IIntegracaoApiPlacaRefit>().ConfigureHttpClient(c =>
        {
            c.BaseAddress = new Uri("https://api.consultarplaca.com.br");
        });

        MapperConfiguration mapperConfiguration = new MapperConfiguration(mapperConfiguration =>
        {
            mapperConfiguration.AddMaps(new[] { "SistemaVeicular.Application" });

        });
        builder.Services.AddSingleton(mapperConfiguration.CreateMapper());


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
