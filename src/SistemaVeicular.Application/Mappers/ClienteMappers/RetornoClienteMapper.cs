using AutoMapper;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Application.Mappers.ClienteMapper.ClienteMappers;
public class RetornoClienteMapper : Profile
{
    public RetornoClienteMapper()
    {
        CreateMap<RetornoClienteDto, Cliente>()
          .ForMember(c => c.Endereco, opt => opt.MapFrom(dto => dto.Endereco))
          .ForMember(c => c.Id, opt => opt.MapFrom(dto => dto.ClienteId))
          .ReverseMap();

        CreateMap<EnderecoDto, Endereco>().ReverseMap();
    }
}
