using System;
using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionPlantillaService
    {
        List<EscuelaConsultaModel> GetEscuelaInaugurada();
        List<CubicacionPlantillaModel> GetCubicacionVer(int idEscuela);
        RevisionModel GetPlantilla(int idRevision);
        RevisionModel GetRevisionCubicacionCambio(int idCubicacion, int idRevision, short revisionNo);
        RevisionModel GetRevisionEscuela(int idEscuela);
        string DateToString(DateTime? fecha);
        RevisionRevisionModel GetRevision(int idRevision);
        int PostRevision(RevisionModel data);
        int Revisor(MpInputRevisionModel input);
        List<RevisionEstatusModel> GetProceso(short idProceso);
        List<RevisionTecnicaEstatusCorreccionModel> GetCorreccion();
        int CorreccionNo(MpInputRevisionModel input);
        int CorreccionSi(MpInputRevisionModel input);

    }
}