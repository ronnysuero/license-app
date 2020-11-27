using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionRevisionService
    {
        List<RevisionRevisionModel> GetLista(string usuario, short idProceso);
        bool PostRevision(RevisionRevisionModel data);
    }
}