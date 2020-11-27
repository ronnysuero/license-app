using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IModeloZapataService
    {
        ModeloZapataModel GetModeloZapata(int idEscuela);
        int PostModeloZapata(ModeloZapataModel data);
    }
}