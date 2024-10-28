using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.EnderecoInterfaces;

namespace SistemaVeicular.Application.Services.EnderecoServices;
public class ViaCepEnderecoService : IViaCepIntegracao
{
    private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;

    public ViaCepEnderecoService(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
    {
        _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
    }
    public async Task<EnderecoViaCepDto> ObterDadosViaCep(string cep)
    {
        var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);



        if (responseData != null && responseData.IsSuccessStatusCode)
        {
            return responseData.Content;
        }

        return null;
        
    }
    
}



    
