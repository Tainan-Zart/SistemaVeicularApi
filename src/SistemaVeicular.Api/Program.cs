
using Microsoft.AspNetCore.Localization;
using SistemaVeicular.Application.Services.ClienteServices;
using SistemaVeicular.Application.Services.EnderecoServices;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces;
using SistemaVeicular.Infrastructure.DataAccess;
using SistemaVeicular.Infrastructure.Repositories.ClienteRepositories;
using SistemaVeicular.Infrastructure.Repositories.EnderecoRepositories;
using System.Globalization;

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

        #region Injeção Application 

        builder.Services.AddScoped<IEnderecoService,  EnderecoService>();
        builder.Services.AddScoped<IClienteService,  ClienteService>();

        #endregion

        #region Injeção Infrasctructure 

        builder.Services.AddScoped<IEnderecoRepository, EndereceRepository>();
        builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

        #endregion

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
