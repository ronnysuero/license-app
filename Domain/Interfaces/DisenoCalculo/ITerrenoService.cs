using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface ITerrenoService
    {
        TerrenoModel GetTerreno(int idEscuela);
        int PostTerreno(TerrenoModel data);
        List<TerrenoTipoModel> GetTipoTerreno();
        List<TerrenoAvanceModel> GetAvance();
    }
}