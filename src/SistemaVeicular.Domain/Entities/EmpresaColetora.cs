using System.Runtime.CompilerServices;

namespace SistemaVeicular.Domain.Entities;
public class EmpresaColetora : BaseEntity
{
    public string Nome { get; set; }

    public string CNPJ { get; set; }

    public string Servicos {get; set; }

    public Endereco Endereco { get; set; }
}
