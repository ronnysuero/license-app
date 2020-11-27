using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Consulta
{
    public interface IConsultaPagoService
    {
        List<ConsultaPagoModel> GetConsultaPago(int idEscuela);
        List<EscuelaConsultaModel> GetEscuela(string login);
    }
}