using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface ICubicacionMovimientoService
    {
        List<CubicacionConsultaModel> GetCubicacionVer(int idEscuela);
        List<EscuelaConsultaModel> GetEscuelaVer();
        List<CubicacionEstatusModel> GetProceso(int idProceso);
        List<CubicacionEstatusModel> GetOrigen(int idCubicacion);
        List<CubicacionEstatusModel> GetRuta(int idProcesoOrigen);
        int Mover(MpInputCubicacionModel input);
    }
}