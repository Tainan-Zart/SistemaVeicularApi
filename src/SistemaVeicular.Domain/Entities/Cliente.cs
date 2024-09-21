namespace SistemaVeicular.Domain.Entities;
public class Cliente : BaseEntity
{
    public string Nome { get; set; } = string.Empty;

    public string Sobrenome { get; set; } = string.Empty;

    public string CPF { get; set; } = string.Empty;

    public DateTime? DataNascimento { get; set; }

    public string Telefone {  get; set; } = string.Empty;

    public string? Email { get; set; }

    public DateTime DataCadastro { get; set; } = DateTime.Now;

    public string? Observacoes { get; set; }

    public Endereco Endereco { get; set; }

    public List<Veiculo> Veiculos { get; set; }

}
