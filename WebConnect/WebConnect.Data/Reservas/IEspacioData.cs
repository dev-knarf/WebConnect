using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas
{
    public interface IEspacioData : ISupportSave<Espacio>, ISupportUpdate<Espacio>, ISupportSearch<Espacio, int>
    {
        
    }
}