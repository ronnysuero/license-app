using System;

namespace Domain.Models
{
    public class PermisoModel
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public short TipoPermisoId { get; set; }
        public DateTime FechaPermiso { get; set; }
        public TipoPermisoModel TipoPermiso { get; set; }
    }
}