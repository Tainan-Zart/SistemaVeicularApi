﻿using SistemaVeicular.Domain.Dtos.EnderecoDtos;
using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Domain.Dtos.ClienteDtos;
public class ClienteDto
{
    public long? Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    public string Sobrenome { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime DataNascimento { get; set; }

    public string Telefone { get; set; } = string.Empty;

    public string? Email { get; set; }

    public EnderecoDto Endereco { get; set; }

}