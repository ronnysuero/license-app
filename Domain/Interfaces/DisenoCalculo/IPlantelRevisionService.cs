using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IPlantelRevisionService
    {
        List<PlantelRevisionModel> GetLista(string usuario, short idProceso);
        bool PostRevision(PlantelRevisionModel data);
    }
}