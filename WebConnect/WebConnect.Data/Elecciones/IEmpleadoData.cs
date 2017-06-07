using WebConnect.Data.Model.Elecciones;
using WebConnect.Data.Support;

namespace WebConnect.Data.Elecciones
{
    public interface IEmpleadoData : ISupportSearch<Empleado, int>
    {
        Empleado GetByNit(string value);
    }
}
