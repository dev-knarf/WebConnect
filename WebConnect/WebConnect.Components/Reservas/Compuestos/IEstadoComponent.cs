using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Model.Security;

namespace WebConnect.Components.Reservas.Compuestos
{
    public interface IEstadoComponent
    {
        void Insert(Estado obj);
        void Update(Estado obj);
        Estado GetById(int value);
        IList<Estado> GetAll();
    }
}