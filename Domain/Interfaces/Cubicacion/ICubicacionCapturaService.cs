using System.Collections;
using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionCapturaService
    {
        IList GetListaPage(short idProceso, string usuario, int pageSize, int currentPage, string filterText, ref int totalPages, bool disponible, string filter);
        List<CubicacionCapturaModel> GetLista(short idProceso, bool disponible);
        bool ValidarCubicacion(CubicacionCapturaModel data);
        bool PostCaptura(CubicacionCapturaModel data);
        bool ProcesoSiguienteCubicacion(int idCubicacion, short idProceso, string condicion);

        bool ProcesoSiguienteCubicacionNext(int idCubicacion, short idProcesoDestino, short idProcesoOrigen,
            string observacion, string login);

        int LimpiarFiscalizacion(int idCubicacion, short idProceso, string observacion);
        List<CubicacionConsultaModel> GetCubicacionVer(int idEscuela);
        List<EscuelaConsultaModel> GetEscuelaVer();
        void LimpiarReauditar(int idCubicacion, short idProceso, string observacion);
        void PostReAuditarHistorico(int idCubicacion, string observacion);
        void PostFiscalizarHistorico(int idCubicacion);
        void PostReFiscalizarHistorico(int idCubicacion, string observacion);
        int ReAuditar(int idCubicacion, short idProceso, string observacion);
        int ReAuditar2(int idCubicacion, short idProceso, int idRevision, string observacion);
        int MesaSinFiscalizar(int idCubicacion);
        CubicacionCapturaModel GetCaptura(int idCubicacion, short idProceso);
        CubicacionCapturaModel GetRevision(int idCubicacion, short idProceso);
        decimal? GetTotalCubicado(short idProceso, string usuario);
    }
}