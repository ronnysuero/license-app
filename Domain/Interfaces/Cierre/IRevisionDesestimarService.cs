using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionDesestimarService
    {
        List<RevisionConsultaModel> GetRevisionVer(int idEscuela);
        List<RevisionConsultaModel> GetEscuelaVer();
        RevisionConsultaModel GetRevisionVerUno(int idEscuela);
        int Desestimar(int idRevision, string observacion);
        void PostDesestimar(int idRevision, string observacion, int idEstatus);
    }
}