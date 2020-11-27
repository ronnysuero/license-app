using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IPlantelCapturaMantenimientoService
    {
        List<PlantelCapturaModel> GetLista(short idProceso);
        bool PostCaptura(PlantelCapturaModel data);
        List<AsignadoPlantelModel> GetAsignado(int idEscuela);
    }
}