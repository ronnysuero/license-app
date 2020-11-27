using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface IPlantelMovimientoService
    {
        List<EscuelaConsultaModel> GetEscuelaVer();
        List<EscuelaEstatusModel> GetProceso(int idProceso);
        List<EscuelaEstatusModel> GetOrigen(int idEscuela);
        List<EscuelaEstatusModel> GetRuta(int idProcesoOrigen);
        int Mover(MpInputModel input);
    }
}