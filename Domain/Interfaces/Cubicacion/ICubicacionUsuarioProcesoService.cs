using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionUsuarioProcesoService
    {
        List<RoleModel> GetUsuarioProcesoDet(string login);
        List<RoleModel> GetUsuario(string cadena);
        bool DeleteUsuarioProcesoDet(CubicacionUsuarioProcesoModel data);
        List<UserProcesoModel> GetUsuarioProceso(string login);
        List<UserProcesoModel> GetProcesoDisponible(string login, short idrol);
        bool PostUsuarioProceso(List<CubicacionUsuarioProcesoModel> data);
    }
}