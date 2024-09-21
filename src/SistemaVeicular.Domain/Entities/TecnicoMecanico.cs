namespace SistemaVeicular.Domain.Entities;
public class TecnicoMecanico : BaseEntity
{
    public string Nome { get; set; } = string.Empty;

    public string Sobrenome { get; set; } = string.Empty;

    public string CPF {  get; set; } = string.Empty;

    public DateTime DataAdmissao { get; set; }

    public string Telefone { get; set; } = string.Empty;

    public string? Email {  get; set; } 

    public List<ServicoManutencao> ServiciosManutencao { get; set; }


}
