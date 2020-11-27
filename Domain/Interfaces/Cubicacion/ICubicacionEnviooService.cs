using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionEnviooService
    {
        CubicacionEnvioMinerdModel GetEnvioO(int idCubicacion, short idProceso);
        int PostEnvioO(CubicacionEnvioMinerdModel data);
    }
}