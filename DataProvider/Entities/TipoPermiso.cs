using System.Collections.Generic;

namespace DataProvider.Entities
{
    public class TipoPermiso
    {
        public TipoPermiso()
        {
            Permisos = new HashSet<Permiso>();
        }

        public short Id { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Permiso> Permisos { get; set; }
    }
}