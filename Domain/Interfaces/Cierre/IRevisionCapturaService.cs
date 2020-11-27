using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionCapturaService
    {
        List<RevisionCapturaModel> GetLista(string usuario, short idProceso);
        bool ValidarRevision(RevisionCapturaModel data);
        bool PostCaptura(RevisionCapturaModel data);
        bool ProcesoSiguienteRevision(int idRevision, short idProceso, string condicion);
        RevisionCapturaModel GetCaptura(int idRevision, short idProceso);
        int Revisor(MpInputRevisionModel input);
        bool SavePlantilla(short idProceso, int idRevision, int idTipoPlantilla);
        bool PostMontoCub(int idRevision);
        bool UpdateRevisionEstatus(int idRevision, short idEstatus, int procesoDestino, int procesoOrigen);
    }
}