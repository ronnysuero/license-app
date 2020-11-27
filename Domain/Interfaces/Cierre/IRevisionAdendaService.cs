using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionAdendaService
    {
        RevisionAdendaModel GetAdenda(int idRevision);
        RevisionAdendaDetalleModel GetAdendaDet(int id);
        List<RevisionAdendaDetalleModel> GetAdendaDetalleAll(int idAdenda);
        int PostAdenda(RevisionAdendaModel data);
        int PostAdendaDet(RevisionAdendaDetalleModel data);
        List<RevisionAdendaEstatusModel> GetAdendaEstatus();
    }
}