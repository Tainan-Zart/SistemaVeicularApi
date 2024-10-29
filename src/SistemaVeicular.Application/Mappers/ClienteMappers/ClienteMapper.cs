using AutoMapper;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Entities;


namespace SistemaVeicular.Application.Mappers.ClienteMappers;
public class ClienteMapper : Profile
{
    public ClienteMapper()
    {
        CreateMap<ClienteDto, Cliente>()
          .ForMember(c => c.Endereco, opt => opt.MapFrom(dto => dto.Endereco))
          .ReverseMap();

        CreateMap<EnderecoDto, Endereco>().ReverseMap();
    }
}
