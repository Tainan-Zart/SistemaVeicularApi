using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces;

namespace SistemaVeicular.Application.Services.EnderecoServices;
public class EnderecoService : IEnderecoService 
{
    private IEnderecoRepository _enderecoRepository;

    public EnderecoService(IEnderecoRepository enderecoRepository)
    {
        _enderecoRepository = enderecoRepository;
    }

    public async Task<bool> Creted(EnderecoDto model)
    {
        var endereco = new Endereco() 
        { 
            Bairro = model.Bairro,
            CEP = model.CEP,
            Cidade = model.Cidade,
            Complemento = model.Complemento,
            Estado  = model.Estado,
            Numero = model.Numero,
            Rua = model.Rua,
        };

        return await _enderecoRepository.Create(endereco);

    }
}
