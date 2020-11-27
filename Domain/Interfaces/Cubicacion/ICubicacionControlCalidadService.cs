using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionControlCalidadService
    {
        CubicacionControlCalidadModel GetControlCalidad(int idCubicacion, short idProceso);
        int PostControlCalidad(CubicacionControlCalidadModel data);
        List<CubicacionControlCalidadEstatusModel> GetEstatus();
    }
}