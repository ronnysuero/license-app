using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IPresupuestoService
    {
        PresupuestoModel GetPresupuesto(int idEscuela);
        int PostPresupuesto(PresupuestoModel data);
    }
}