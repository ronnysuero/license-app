using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IPlantelUsuarioProcesoService
    {
        List<RoleModel> GetUsuarioProcesoDet(string login);
        List<RoleModel> GetUsuario(string cadena);
        bool DeleteUsuarioProcesoDet(UsuarioProcesoModel data);
        List<UserProcesoModel> GetUsuarioProceso(string login);
        List<UserProcesoModel> GetProcesoDisponible(string login, short idrol);
        bool PostUsuarioProceso(List<UsuarioProcesoModel> data);
    }
}