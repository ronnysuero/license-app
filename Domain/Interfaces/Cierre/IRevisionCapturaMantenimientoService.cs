using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionCapturaMantenimientoService
    {
        List<RevisionCapturaModel> GetLista(short idProceso);
        bool PostCaptura(RevisionCapturaModel data);
        List<AsignadoRevisionModel> GetAsignado(int idRevision);
    }
}