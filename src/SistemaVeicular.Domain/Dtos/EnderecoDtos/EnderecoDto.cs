using SistemaVeicular.Domain.Entities;

namespace SistemaVeicular.Domain.Dtos.EnderecoDtos;
public class EnderecoDto
{
    public string Rua { get; set; } = string.Empty;

    public string Numero { get; set; } = string.Empty;

    public string Complemento { get; set; } = string.Empty;

    public string Bairro { get; set; } = string.Empty;

    public string Cidade { get; set; } = string.Empty;

    public string Estado { get; set; } = string.Empty;

    public string CEP { get; set; } = string.Empty;


}
