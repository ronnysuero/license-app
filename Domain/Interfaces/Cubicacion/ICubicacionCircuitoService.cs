using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionCircuitoService
    {
        CubicacionCircuitoModel GetCircuito(int idCubicacion, short idProceso);
        int PostCircuito(CubicacionCircuitoModel data);
        List<CubicacionCircuitoEstatusModel> GetCircuitoEstatus();
        List<CubicacionCircuitoEstatusContraloriaModel> GetEstatusContraloria();
        List<CubicacionCircuitoEstatusTesoreriaModel> GetEstatusTesoreria();
        List<CubicacionCircuitoEstatusFiscalizacionModel> GetEstatusFiscalizacion();
        List<CubicacionCircuitoEstatusFinancieroModel> GetEstatusFinanciero();
        bool SpUpdateEscuela(int idCubicacion);
    }
}