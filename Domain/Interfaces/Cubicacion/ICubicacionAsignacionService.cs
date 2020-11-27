using System.Collections;
using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionAsignacionService
    {
        IList GetListaPage(short idProceso, string usuario, int pageSize, int currentPage, string filterText, string filter, ref int totalPages);
        List<CubicacionAsignacionModel> GetLista(short idProceso);
        bool PostAsignacion(CubicacionAsignacionModel data);
        List<RoleModel> GetRoles(string cadena, short idproceso);
        List<AsignadoCubicadoModel> Asignado(string usuario);
    }
}