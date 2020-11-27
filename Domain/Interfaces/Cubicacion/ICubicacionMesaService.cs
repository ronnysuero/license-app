using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionMesaService
    {
        CubicacionMesaModel GetMesa(int idCubicacion, short idProceso);
        int PostMesa(CubicacionMesaModel data);
        List<CubicacionMesaEstatusDevolucionModel> GetEstatusDev();
        List<CubicacionMesaEstatusModel> GetEstatus();
    }
}