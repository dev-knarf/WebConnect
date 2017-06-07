using System.Collections.Generic;
using WebConnect.Data.Model.Elecciones;

namespace WebConnect.Components.Elecciones
{
    public interface IEmpleadoComponent
    {
        Empleado GetById(int value);
        Empleado GetByNit(string value);
        IList<Empleado> GetAll();
    }
}