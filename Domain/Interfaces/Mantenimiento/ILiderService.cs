using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface ILiderService
    {
        List<LiderModel> GetListaLider();
        LiderModel GetLider(int idLider);
        int PostLider(LiderModel data);
        List<EscuelaConsultaModel> GetEscuelaLider(int idLider);
        List<EscuelaConsultaModel> GetListLider(int idLider, string query);
        int DeleteEscuelaLider(EscuelaModel data);
        int PostListLider(List<IdPlantelModel> data, int idLider);
    }
}