using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ITipoPermisoService
    {
        IEnumerable<TipoPermisoModel> Get();
    }
}