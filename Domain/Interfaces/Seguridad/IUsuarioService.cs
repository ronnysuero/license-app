using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Seguridad
{
    public interface IUsuarioService
    {
        List<UserModel> GetListaUsuario();
        usersModel GetUsuario(int idUser);
        int PostUsuario(usersModel data);
        string PostUsuarioCoordinador(userCoordinadorModel data);
        List<UserModel> GetProcesoDisponible(string uid);
        List<counttypeModel> GetTipoUsuario();
        List<UserModel> GetMenu();
        List<UserModel> GetUsuarioMenu(string login);
        bool DeleteModuleMenu(UserModel data);
        bool PostModuleMenu(List<accessmoduleModel> data);
        int GetType(string uid);
        int GetUsuarioCoordinador(string uid);
    }
}