using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionPlantillaService
    {
        CubicacionModel GetCubicacion(int idCubicacion, short idProceso);
        CubicacionModel GetCubicacionR(int idCubicacion, short idProceso);
        CubicacionModel GetEscuelaCubicacion(int idEscuela);
        int PostCubicacion(CubicacionModel data);
        int UpdateCubicacionR(CubicacionModel data);
        int GetSupervisorEscuela(int idEscuela);
        int GetProcesoCubicacion(int idCubicacion);
        List<CubicacionModel> GetCubicacionAll(int idEscuela);
        bool PostEnvio(int idCubicacion);
        List<CubicacionDigitacionPlantillaEstatusModel> GetEstatusPlantilla();
        List<CubicacionDigitacionRecepcionEstatusModel> GetEstatusRecepcion();
    }
}