using System.Collections;
using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionRevisionService
    {
        IList GetListaPage(short idProceso, string usuario, int pageSize, int currentPage, string filterText,
            string filter, ref int totalPages);

        List<CubicacionRevisionModel> GetLista(short idProceso);
        bool PostRevision(CubicacionRevisionModel data);
    }
}