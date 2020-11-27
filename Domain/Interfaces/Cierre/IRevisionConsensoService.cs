using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionConsensoService
    {
        RevisionConsensoModel GetConsenso(int idRevision);
        RevisionConsensoDetalleModel GetConsensoDet(int id);
        List<RevisionConsensoDetalleModel> GetConsensoDetalleAll(int idConsenso);
        int PostConsenso(RevisionConsensoModel data);
        int PostConsensoDet(RevisionConsensoDetalleModel data);
        List<RevisionConsensoEstatusModel> GetConsensoEstatus();
    }
}