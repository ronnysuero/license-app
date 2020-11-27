using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionDevolucionService
    {
        CubicacionDevolucionModel GetDev(int idCubicacion, short idProceso);
        CubicacionDevolucionModel GetDev2(int idCubicacion);
        int PostDev(CubicacionDevolucionModel data);
    }
}