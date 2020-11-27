using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionInfoService
    {
        List<CubicacionInfoModel> GetInfoAllHistorico(int idCubicacion, short idProceso);
        List<CubicacionInfoModel> GetInfoAll(int idCubicacion, short idProceso);
        MoverProcesoCubicacionModel GetInfo(int idCubicacion, short idProceso);
        List<CubicacionFiscHistModel> GetFiscAll(int idCubicacion, short idProceso);
        List<CubicacionFiscHistModel> GetReauditarAll(int idCubicacion, short idProceso);
        List<CubicacionFiscHistModel> GetRefiscalizarAll(int idCubicacion, short idProceso);
        List<CubicacionFiscHistModel> GetDevolucionAll(int idCubicacion, short idProceso);
        List<CubicacionFiscHistModel> GetDesestimarAll(int idRevision);
    }
}