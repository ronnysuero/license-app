using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface IPlantelNoDisponibleService
    {
        List<EscuelaConsultaModel> GetListaPlantelNoDisponible();
        EscuelaConsultaModel GetPlantelNoDisponible(int idEscuela);
        int PostPlantelNoDisponible(EscuelaModel data);
    }
}