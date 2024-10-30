using AutoMapper;
using SistemaVeicular.Domain.Dtos.ClienteDtos;
using SistemaVeicular.Domain.Dtos.EmpresaColetoraDtos;
using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeicular.Application.Mappers.EmpresaColetoraMappers
{
    public class RetornoEmpresaColetoraMapper : Profile
    {
        public RetornoEmpresaColetoraMapper()
        {
            CreateMap<RetornoEmpresaColetoraDto, EmpresaColetora>()
              .ForMember(c => c.Endereco, opt => opt.MapFrom(dto => dto.Endereco))
              .ForMember(c => c.Id, opt => opt.MapFrom(dto => dto.EmpresaColetoraId))
              .ReverseMap();

            CreateMap<EnderecoDto, Endereco>().ReverseMap();
        }
    }
}
