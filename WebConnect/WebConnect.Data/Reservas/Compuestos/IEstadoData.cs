using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas.Compuestos
{
    public interface IEstadoData : ISupportSave<Estado>, ISupportUpdate<Estado>, ISupportSearch<Estado, int>
    {
        
    }
}