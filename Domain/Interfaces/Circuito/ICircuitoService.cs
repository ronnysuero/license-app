using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Circuito
{
    public interface ICircuitoService
    {
        PlantelCircuitoModel GetEscuela(int idEscuela);
        List<CircuitoConsultaModel> GetCubicacionAll(int idEscuela);
    }
}