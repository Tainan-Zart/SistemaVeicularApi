using SistemaVeicular.Domain.Enums;

namespace SistemaVeicular.Domain.Entities;
public class Veiculo : BaseEntity
{
    public string Modelo { get; set; } = string.Empty;

    public string Placa { get; set; } = string.Empty;

    public int Ano { get; set; }

    public MarcaEnum Marca { get; set; }

    public CilindradaMotorEnum CilindradaMotor { get; set; }

    public CoresEnum Cor {  get; set; } 

    public long ClienteId { get; set; }

    public Cliente Cliente { get; set; }

    public List<ServicoManutencao> ServicioManutencao { get; set; }

}
