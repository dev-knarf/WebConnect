using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas.Compuestos
{
    public interface IClaseDependenciaData : ISupportSave<ClaseDependencia>, ISupportUpdate<ClaseDependencia>, ISupportSearch<ClaseDependencia, int>
    {
        
    }
}