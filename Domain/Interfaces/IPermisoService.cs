using System.Collections.Generic;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IPermisoService
    {
        IEnumerable<PermisoModel> Get();
        PermisoModel Update(PermisoModel model);
        PermisoModel Add(PermisoModel model);
        bool Delete(int id);
    }
}