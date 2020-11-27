using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IPlantelCapturaService
    {
        List<PlantelCapturaModel> GetLista(string usuario, short idProceso);
        bool PostCaptura(PlantelCapturaModel data);
        bool ProcesoSiguientePlantel(int idEscuela, short idProceso, string condicion);
        PlantelCapturaModel GetCaptura(int idEscuela, short idProceso);
        List<AsignadoPlantelModel> GetAsignado(int idEscuela);
        int Revisor(MpInputModel input);
    }
}