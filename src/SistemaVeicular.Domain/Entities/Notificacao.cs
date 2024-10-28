namespace SistemaVeicular.Domain.Entities;
public class Notificacao : BaseEntity
{
    public string Mensagem { get; set; }

    public DateTime DataNotificacao { get; set; }

    public bool Enviada { get; set; }

    public long ServicoManutencaoId { get; set; }

    public ServicoManutencao ServicoManutencao { get; set; }

}
