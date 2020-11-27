using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface ILevTopograficoService
    {
        LevTopograficoModel GetLevTopografico(int idEscuela);
        int PostLevTopografico(LevTopograficoModel data);
    }
}