using System;

namespace DataProvider.Entities
{
    public class Permiso
    {
        public int Id { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public short TipoPermisoId { get; set; }
        public DateTime FechaPermiso { get; set; }

        public TipoPermiso TipoPermiso { get; set; }
    }
}