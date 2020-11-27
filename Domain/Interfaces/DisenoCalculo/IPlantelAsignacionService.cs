using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IPlantelAsignacionService
    {
        List<PlantelAsignacionModel> GetLista(string usuario, short idProceso);
        bool PostAsignacion(PlantelAsignacionModel data);
        List<RoleModel> GetRoles(string cadena, short idProceso);
        List<AsignadoPlantelModel> Asignado(string usuario);
    }
}