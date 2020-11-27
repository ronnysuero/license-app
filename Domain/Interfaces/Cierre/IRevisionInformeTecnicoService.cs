using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionInformeTecnicoService
    {
        RevisionInformeTecnicoModel GetInformeTecnico(int idRevision);
        int PostInformeTecnico(RevisionInformeTecnicoModel data);
    }
}