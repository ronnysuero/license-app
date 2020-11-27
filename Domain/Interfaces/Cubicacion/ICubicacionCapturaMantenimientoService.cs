using System.Collections;
using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cubicacion
{
    public interface ICubicacionCapturaMantenimientoService
    {
        IList GetListaPage(short idProceso, int pageSize, int currentPage, string filterText, ref int totalPages);
        bool PostCaptura(CubicacionCapturaModel data);
        List<AsignadoCubicadoModel> GetAsignado(int idCubicacion);
    }
}