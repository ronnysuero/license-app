using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface ICoordinadorSupervisorService
    {
        List<CoordinadorSupervisorModel> GetListaCoordinadorSupervisor();
        CoordinadorSupervisorModel GetCoordinadorSupervisor(int idCoordinadorSupervisor);
        int PostCoordinadorSupervisor(CoordinadorSupervisorModel data);
        List<EscuelaConsultaModel> GetEscuelaCoordinadorSupervisor(int idCoordinadorSupervisor);
        List<EscuelaConsultaModel> GetListCoordinadorSupervisor(int idCoordinadorSupervisor, string query);
        int DeleteEscuelaCoordinadorSupervisor(EscuelaModel data);
        int PostListCoordinadorSupervisor(List<IdPlantelModel> data, int idCoordinadorSupervisor);
    }
}