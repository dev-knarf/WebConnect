using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas
{
    public interface IHoraData : ISupportSave<Hora>, ISupportSearch<Hora, int>
    {
        
    }
}