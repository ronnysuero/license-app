using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Cierre
{
    public interface IRevisionInfoService
    {
        List<RevisionInfoModel> GetInfoAll(int idRevision, short idProceso);
        MoverProcesoRevisionModel GetInfo(int idRevision, short idProceso);
        List<RevisionInfoModel> GetInfoAllHistorico(int idRevision, short idProceso);
    }
}