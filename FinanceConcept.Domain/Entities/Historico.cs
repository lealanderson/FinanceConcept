namespace FinanceConcept.Domain.Entities;

public class Historico : BaseEntity
{
    public Historico(EHistoricoStatus status, EHistoricoFluxo fluxo, string descricao)
    {
        Status = status;
        Fluxo = fluxo;
        Descricao = descricao;
    }

    public EHistoricoStatus Status { get; private set; }
    public EHistoricoFluxo Fluxo { get; private set; }
    public string Descricao { get; private set; }
}
