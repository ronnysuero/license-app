using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionMesaContraloriaService
    {
        CubicacionMesaContraloriaModel GetMesaContraloria(int idCubicacion, short idProceso);
        int PostMesaContraloria(CubicacionMesaContraloriaModel data);
        List<CubicacionMesaContraloriaEstatusModel> GetEstatus();
    }
}