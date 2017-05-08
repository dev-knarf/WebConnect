using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas.Compuestos
{
    public interface ITipoDependenciaData : ISupportSave<TipoDependencia>, ISupportUpdate<TipoDependencia>, ISupportSearch<TipoDependencia, int>
    {
        
    }
}