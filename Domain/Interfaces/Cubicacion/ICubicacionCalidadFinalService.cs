using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionCalidadFinalService
    {
        CubicacionCalidadFinalModel GetCalidadFinal(int idCubicacion, short idProceso);
        CubicacionCalidadFinalModel GetFiscalizacion(int idCubicacion);
        int PostCalidadFinal(CubicacionCalidadFinalModel data);
        int PostFiscalizacion(CubicacionCalidadFinalModel data);
        List<CubicacionCalidadFinalEstatusModel> GetCubicacionCalidadFinalEstatus();
        List<CubicacionFiscalizacionEstatusModel> GetCubicacionCalidadFinalEstatusFiscalizacion();
        List<CubicacionFiscalizacionAccionModel> GetCubicacionCalidadFinalAccionFiscalizacion();
        List<CubicacionCalidadFinalAccionModel> GetIdAccionReauditar();
        List<CubicacionCalidadFinalEstatusDevolucionModel> GetEstatusDev();
        short GetEstadoCubFinal(int idCubicacion);
        List<CubicacionCalidadFinalFormatoEnvioModel> GetCubicacionCalidadFinalFormatoEnvio();
    }
}