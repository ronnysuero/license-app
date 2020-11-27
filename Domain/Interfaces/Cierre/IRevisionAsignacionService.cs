using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionAsignacionService
    {
        List<RevisionAsignacionModel> GetLista(string usuario, short idProceso);
        bool PostAsignacion(RevisionAsignacionModel data);
        List<RoleModel> GetRoles(string cadena, short idproceso);
        bool EnvioAdenda(int idRevision);
        List<AsignadoRevisionModel> Asignado(string usuario);
    }
}