using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas.Compuestos
{
    public interface IEstadoReservaData : ISupportSave<EstadoReserva>, ISupportUpdate<EstadoReserva>, ISupportSearch<EstadoReserva, int>
    {
        
    }
}