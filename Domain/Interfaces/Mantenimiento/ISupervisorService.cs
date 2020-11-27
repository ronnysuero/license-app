using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface ISupervisorService
    {
        List<SupervisorModel> GetListaSupervisor();
        SupervisorModel GetSupervisor(int idSupervisor);
        int PostSupervisor(SupervisorModel data);
        List<EscuelaConsultaModel> GetEscuelaSupervisor(int idSupervisor);
        List<EscuelaConsultaModel> GetListSupervisor(int idSupervisor, string query);
        int DeleteEscuelaSupervisor(EscuelaModel data);
        int PostListSupervisor(List<IdPlantelModel> data, int idSupervisor);
    }
}