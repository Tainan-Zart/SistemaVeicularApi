using System.Runtime.CompilerServices;

namespace SistemaVeicular.Domain.Entities;
public class EmpresaColetora : BaseEntity
{
    public string Nome { get; set; } = string.Empty;

    public string CNPJ { get; set; } = string.Empty;

    public string Servicos { get; set; } = string.Empty;

    public Endereco Endereco { get; set; }
}
