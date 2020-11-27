using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface ICoordinadorService
    {
        List<CoordinadorProvincialModel> GetAll();
        CoordinadorProvincialModel Get(int idCoordinador);
        int Post(CoordinadorProvincialModel data);
        List<EscuelaConsultaModel> GetEscuelaCoordinador(int idCoordinador);
        List<EscuelaConsultaModel> GetListCoordinador(int idCoordinador, string query);
        int DeleteEscuelaCoordinador(EscuelaModel data);
        int PostListCoordinador(List<IdPlantelModel> data, int idCoordinador);
    }
}