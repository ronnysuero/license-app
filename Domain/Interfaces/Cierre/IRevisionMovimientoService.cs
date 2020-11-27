using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionMovimientoService
    {
        List<RevisionConsultaModel> GetRevisionVer(int idEscuela);
        List<RevisionConsultaModel> GetEscuelaVer();
        List<RevisionConsultaModel> GetEscuelaVerReauditar();
        List<RevisionEstatusModel> GetProceso(int idProceso);
        List<RevisionEstatusModel> GetOrigen(int idRevision);
        List<RevisionEstatusModel> GetRuta(int idProcesoOrigen);
        int Mover(MpInputRevisionModel input);
        RevisionConsultaModel GetRevisionVerUno(int idEscuela);
    }
}