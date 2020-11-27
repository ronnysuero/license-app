using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionHistoricoService
    {
        List<MoverProcesoRevisionModel> GetHistoricoAll(int idRevision);
        MoverProcesoRevisionModel GetHistorico(int idRevision, short idProceso);
    }
}