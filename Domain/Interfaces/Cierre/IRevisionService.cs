using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionService
    {
        EscuelaConsultaModel GetEscuela(int idEscuela);
        List<RevisionConsultaModel> GetRevisionAll(int idEscuela);
    }
}