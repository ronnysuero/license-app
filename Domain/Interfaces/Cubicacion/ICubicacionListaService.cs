using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionListaService
    {
        CubicacionRevisionListaDocModel GetLista(int idCubicacion);
        CubicacionRevisionListaDocModel GetListaEscuela(int idEscuela, short noCubicacion);
        IdAndStatusModel PostLista(CubicacionRevisionListaDocModel data);
    }
}