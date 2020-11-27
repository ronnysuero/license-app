using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Consulta
{
    public interface IEstatusService
    {
        EstatusView1Model GetEstatusSp(int idEscuela);
        EstatusView1Model GetEstatus(int idEscuela);
        EstatusView2Model GetEstatus2(int idEscuela, short noCubicacion);
        List<ProcesoModel> GetEstatusProceso(int idEscuela);
        List<ProcesoModel> GetProceso(int idEscuela);
        int GetUltimaFicha(int idEscuela);
    }
}