using AutoMapper;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Entities;
using SistemaVeicular.Domain.Interfaces.ApplicationInterfaces.ClienteInterfaces;
using SistemaVeicular.Domain.Interfaces.InfrastructureInterfaces.ClienteInterfaces;

namespace SistemaVeicular.Application.Services.ClienteServices;
public class ClienteService : IClienteService
{
    private readonly IMapper _mapper;
    private readonly IClienteRepository _clienteRepositoy;
    

    public ClienteService(IClienteRepository clienteRepositoy, IMapper mapper)
    {
        _mapper = mapper;
        _clienteRepositoy = clienteRepositoy;
    }

    public async Task<bool> Cadastrar(ClienteDto model)
    {
       var cliente = _mapper.Map<Cliente>(model);
       return await _clienteRepositoy.Salvar(cliente);
    }

    public async Task<List<RetornoClienteDto>> BuscarPorId(BuscaClienteIdDTo model)
    {
        var cliente =  await _clienteRepositoy.BuscarPorId(model);
        var response = _mapper.Map<List<RetornoClienteDto>>(cliente);
        return response;
    }

    public async Task<List<RetornoClienteDto>> BuscarTodos()
    {
        var clientes = await _clienteRepositoy.BuscarTodos();
        var response = _mapper.Map<List<RetornoClienteDto>>(clientes);
        return response;
    }

    public async Task Deletar(DeletarClienteDTO model)
    {
        await _clienteRepositoy.Excluir(model.Id);
    }

}
