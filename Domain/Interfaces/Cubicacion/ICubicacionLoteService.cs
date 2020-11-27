using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionLoteService
    {
        List<CubicacionMovimientoModel> GetLista(short idProceso, string tipoDoc);
        CubicacionMovimientoModel GetMovimiento(int idMovimiento);
        List<CubicacionCapturaModel> GetMovimientoDetalle(int idMovimiento);
        List<CubicacionCapturaModel> GetListMovimiento(string query, short idProceso, int idMovimiento);
        int DeleteMovimientoDetalle(int idDetalle);

        int PostListMovimiento(CubicacionMovimientoModel data,
            List<CubicacionMovimientoDetalleModel> det, short idProceso);

        int PostMovimiento(CubicacionMovimientoModel data, short idProceso);
        bool ProcesarMovimiento(int idMovimiento, short idProceso, string tipoDoc, short idProcesoDestino);
    }
}