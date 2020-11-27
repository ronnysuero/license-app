using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface ICubNoDisponibleService
    {
        List<CubicacionIModel> GetListaCubNoDisponible();
        CubicacionModel GetCubNoDisponible(int idCubicacion);
        int PostCubNoDisponible(CubicacionModel data);
    }
}