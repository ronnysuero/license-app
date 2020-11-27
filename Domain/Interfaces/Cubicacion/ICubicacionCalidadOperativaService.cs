using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionCalidadOperativaService
    {
        CubicacionCalidadOperativaModel GetCalidadOperativa(int idCubicacion, short idProceso);
        int PostCalidadOperativa(CubicacionCalidadOperativaModel data);
        List<CubicacionCalidadOperativaEstatusModel> GetEstatus();
    }
}