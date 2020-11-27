using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionReasignarService
    {
        bool Reasignar(string login, int idrevision);
        List<UserModel> ListaUsuarioCierre();
    }
}