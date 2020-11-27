using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IEstudioSueloService
    {
        EstudioSueloModel GetEstudioSueldo(int idEscuela);
        int PostEstudioSuelo(EstudioSueloModel data);
    }
}