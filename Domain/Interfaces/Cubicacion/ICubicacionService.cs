using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionService
    {
        CubicacionModel GetCubicacion(int idCubicacion, short idProceso);
        CubicacionSicconModel GetCubicacionSiccon(int idEscuela, short noCubicacion);
        CubicacionNuevoModel GetEscuelaCubicacion(int idEscuela);
        int PostCubicacion(CubicacionModel data);
        bool SpUpdateEscuela(int idEscuela, int idCubicacion);
        bool SpUpdateCubicacionEstatus(int idCubicacion, short estatus, short procesoDestino, short procesoOrigen);
        bool SpAcumularCubicacion(int idEscuela);
        List<CubicacionModel> GetCubicacionAll(int idEscuela);
        List<CubicacionModel> GetCubicacionPlantillaAll(int idEscuela);
        int Revisor(MpInputCubicacionModel input);
        int LimpiarRevisor(int idCubicacion);
        int Fiscalizar(MpInputCubicacionModel input);
        int RevisorAdenda(MpInputCubicacionModel input);
        List<CubicacionTipoModel> GetTipoCubicacion();
        List<CubicacionTipoModeloModel> GetModelo();
        int GetModeloPlantilla(int idEscuela, int noCubicacion);
        List<CubicacionVersionModel> GetIdVersion();
        List<CubicacionTipoModel> GetTipoSinCierre();
        CubicacionTotalModel TotalizarCubicacion(int idEscuela);
    }
}