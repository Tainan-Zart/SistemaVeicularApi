using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.ClienteInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;

namespace SistemaVeicular.Application.Services.ClienteServices;
public class ClienteService : IClienteService
{
    private readonly IClienteRepository _clienteRepositoy;

    public ClienteService(IClienteRepository clienteRepositoy)
    {
        _clienteRepositoy = clienteRepositoy;
    }

    public async Task<bool> Cadastrar(ClienteDto model)
    {
        var cliente = new Cliente()
        {
            Nome = model.Nome,
            Sobrenome = model.Sobrenome,
            CPF = model.CPF,
        
            Email = model.Email,
            Endereco = new Endereco
            {
                Rua = model.Endereco.Rua,
                Numero = model.Endereco.Numero,
                Bairro = model.Endereco.Bairro,
                Cidade = model.Endereco.Cidade,
                Estado = model.Endereco.Estado,
                CEP = model.Endereco.CEP
            },
            Observacao = model.Observacoes,
            Telefone = model.Telefone,
        };

        return await _clienteRepositoy.Salvar(cliente);
    }

}
