using System.Collections.Generic;
using WebConnect.Data.Elecciones;
using WebConnect.Data.Model.Elecciones;

namespace WebConnect.Components.Elecciones
{
    public class EmpleadoComponent : AbstractComponent<IEmpleadoData>, IEmpleadoComponent
    {
        public Empleado GetById(int value) => Invoke().GetById(value);

        public Empleado GetByNit(string value) => Invoke().GetByNit(value);

        public IList<Empleado> GetAll() => Invoke().GetAll();
    }
}