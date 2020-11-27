using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionCalidadTecnicaService
    {
        CubicacionCalidadTecnicaModel GetCalidadTecnica(int idCubicacion, short idProceso);
        int PostCalidadTecnica(CubicacionCalidadTecnicaModel data);
        List<CubicacionCalidadTecnicaEstatusModel> GetEstatus();
    }
}