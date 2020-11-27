using System.Collections.Generic;
using Sigede.Domain.Models;

namespace Sigede.Domain.Interfaces.Mantenimiento
{
    public interface IDigitadorService
    {
        List<DigitadorModel> GetListaDigitador();
        DigitadorModel GetDigitador(int idDigitador);
        int PostDigitador(DigitadorModel data);
    }
}