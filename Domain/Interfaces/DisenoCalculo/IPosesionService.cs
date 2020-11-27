using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IPosesionService
    {
        PosesionModel GetPosesion(int idEscuela);
        int PostPosesion(PosesionModel data);
    }
}