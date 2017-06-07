using WebConnect.Data.Model.Elecciones;
using WebConnect.Data.Model.Elecciones.Types;

namespace WebConnect.Data.Elecciones
{
    public class EmpleadoData : AbstractData<Empleado, int>, IEmpleadoData
    {
        public Empleado GetByNit(string value)
        {
            return Session.QueryOver<Empleado>()
                          .Where(e => e.Nit == value && e.Estado == Estado.A)
                          .SingleOrDefault();
        }
    }
}