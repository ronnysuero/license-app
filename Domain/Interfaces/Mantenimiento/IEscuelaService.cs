using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface IEscuelaService
    {
        EscuelaModel GetEscuela(int idEscuela);
        int PostEscuela(EscuelaModel data);
    }
}