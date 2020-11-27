using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionFirmaeService
    {
        CubicacionFirmaEModel GetFirmaE(int idCubicacion, short idProceso);
        int PostFirmaE(CubicacionFirmaEModel data);
        List<CubicacionFirmaEEstatusModel> GetEstatus();
    }
}