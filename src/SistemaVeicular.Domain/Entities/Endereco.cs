using System.ComponentModel.DataAnnotations;

namespace SistemaVeicular.Domain.Entities;
public class Endereco : BaseEntity
{
    public string Rua { get; set; } = string.Empty;

    public string Numero { get; set; } = string.Empty;

    public string Complemento {  get; set; } = string.Empty;

    public string Bairro { get; set; } = string.Empty;

    public string Cidade { get; set; } = string.Empty;

    public string Estado { get; set; } = string.Empty;

    public string CEP {  get; set; } = string.Empty;

    public long? ClienteId { get; set; }

    public long? EmpresaColetoraId { get; set; }

    public long? TecnicoMecanicoId { get; set; }

    public Cliente Cliente { get; set; }

    public EmpresaColetora EmpresaColetora { get; set; }

    public TecnicoMecanico TecnicoMecanico { get; set; }
}
