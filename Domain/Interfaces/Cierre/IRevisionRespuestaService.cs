using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionRespuestaService
    {
        RevisionRespuestaTecnicaModel GetRespuesta(int idRevision);
        int PostRespuesta(RevisionRespuestaTecnicaModel data);
        List<RevisionRespuestaTecnicaEstatusModel> GetEstatus();
    }
}