using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionTecnicaService
    {
        RevisionModel GetRevision(int idRevision);
        int PostRevision(RevisionModel data);
        List<RevisionTecnicaEstatusModel> GetEstatus();
        List<RevisionTecnicaEstatusTercerosModel> GetEstatusT();
    }
}