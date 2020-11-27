using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionContratoService
    {
        RevisionContratoModel GetContrato(int idRevision);
        int PostContrato(RevisionContratoModel data);
        List<RevisionContratoEstatusModel> GetContratoEstatus();
    }
}