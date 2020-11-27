using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionFiscalizacionService
    {
        List<CubicacionFiscalizacionEstatusModel> GetCubicacionFiscalizacionEstatus();
    }
}