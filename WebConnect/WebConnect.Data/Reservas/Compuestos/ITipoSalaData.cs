using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas.Compuestos
{
    public interface ITipoSalaData : ISupportSave<TipoSala>, ISupportUpdate<TipoSala>, ISupportSearch<TipoSala, int>
    {
        
    }
}