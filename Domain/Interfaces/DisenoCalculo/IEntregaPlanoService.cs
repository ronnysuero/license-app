using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.DisenoCalculo
{
    public interface IEntregaPlanoService
    {
        EntregaPlanosModel GetEntregaPlano(int idEscuela);
        int PostEntregaPlano(EntregaPlanosModel data);
        List<EntregaViaModel> GetViaEntrega();
    }
}