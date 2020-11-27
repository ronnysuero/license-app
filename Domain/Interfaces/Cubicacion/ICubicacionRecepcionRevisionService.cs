using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionRecepcionRevisionService
    {
        CubicacionRecepcionRevisionModel GetRecepcionRevision(int idCubicacion, short idProceso);
        int PostRecepcionRevision(CubicacionRecepcionRevisionModel data);
        List<CubicacionRecepcionRevisionEstatusModel> GetEstatus();
        List<CubicacionRecepcionRevisionEstatusConsensoModel> GetEstatusConsenso();
    }
}