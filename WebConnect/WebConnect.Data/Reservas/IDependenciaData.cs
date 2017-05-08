using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas
{
    public interface IDependenciaData : ISupportSave<Dependencia>, ISupportUpdate<Dependencia>, ISupportSearch<Dependencia, int>
    {
        
    }
}