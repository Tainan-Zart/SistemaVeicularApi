﻿using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeicular.Domain.Dtos.EmpresaColetoraDtos
{
    public class RetornoEmpresaColetoraDto
    {
        public long EmpresaColetoraId { get; set; }
        public string Nome { get; set; } = string.Empty;

        public string CNPJ { get; set; } = string.Empty;

        public string Servicos { get; set; } = string.Empty;

        public EnderecoDto Endereco { get; set; }
    }
}