using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionUsuarioProcesoService
    {
        List<RoleModel> GetUsuarioProcesoDet(string login);
        List<RoleModel> GetUsuario(string cadena);
        bool DeleteUsuarioProcesoDet(RevisionUsuarioProcesoModel data);
        List<UserProcesoModel> GetUsuarioProceso(string login);
        List<UserProcesoModel> GetProcesoDisponible(string login, short idrol);
        bool PostUsuarioProceso(List<RevisionUsuarioProcesoModel> data);
    }
}