using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Model.Security;

namespace WebConnect.Components.Reservas.Compuestos
{
    public interface IClaseDependenciaComponent
    {
        void Insert(ClaseDependencia obj);
        void Update(ClaseDependencia obj);
        ClaseDependencia GetById(int value);
        IList<ClaseDependencia> GetAll();
    }
}