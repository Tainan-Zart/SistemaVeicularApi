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
    public class EmpresaColetoraMapper : Profile
    {
        public EmpresaColetoraMapper()
        {
            CreateMap<EmpresaColetoraDto, EmpresaColetora>()
              .ForMember(c => c.Endereco, opt => opt.MapFrom(dto => dto.Endereco))
              .ReverseMap();

            CreateMap<EnderecoDto, Endereco>().ReverseMap();
        }
    }
}
