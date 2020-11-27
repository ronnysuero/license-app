using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionHistoricoService
    {
        List<MoverProcesoCubicacionModel> GetHistoricoAll(int idCubicacion);
        MoverProcesoCubicacionModel GetHistorico(int idCubicacion, short idProceso);
    }
}