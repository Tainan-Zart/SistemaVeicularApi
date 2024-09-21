using SistemaVeicular.Domain.Enums;

namespace SistemaVeicular.Domain.Entities;
public class ServicoManutencao : BaseEntity
{
    public TipoManutencaoEnum Tipo { get; set; }

    public string NomeProblema { get; set; } = string.Empty;

    public DateTime DataReparo { get; set; }

    public string Quilometragem { get; set; } = string.Empty;

    public string Relatorio { get; set; } = string.Empty;

    public double CustoManutencao { get; set; }

    public string Garantia { get; set; } = string.Empty;

    public long TecnicoMecanicoId { get; set; }

    public long VeiculoId { get; set; }

    public TecnicoMecanico TecnicoMecanico { get; set; }

    public Veiculo Veiculo { get; set; }
    
}
