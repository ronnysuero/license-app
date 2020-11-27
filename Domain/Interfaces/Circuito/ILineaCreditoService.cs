using System.Collections.Generic;

namespace Sigede.Domain.Interfaces.Circuito
{
    public interface ILineaCreditoService
    {
        LineaCreditoView GetEscuela(int idEscuela);
        List<LineaView> GetLineaAll(int idEscuela);
        LineaCredito GetLinea(int id);
        List<TransaccionView> GetTransaccionAll(int idLinea, int idDesembolso, string tipoTransaccion);
        LineaCreditoTransaccion GetTransaccion(int id);
        int PostLinea(LineaCredito data);
        int PostTransaccion(LineaCreditoTransaccion data);
        List<InstitucionView> GetInstitucion();
        List<LineaEstatusView> GetEstatus();
        bool DeleteLinea(int idLinea);
        bool DeleteDesembolso(int id);
        bool DeletePago(int id);
        bool SpUpdateEscuelaLineaCredito(int idLinea);
    }
}