using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Components.Reservas
{
    public interface IEspacioComponent
    {
        void Insert(Espacio obj);
        void Update(Espacio obj);
        Espacio GetById(int value);
        IList<Espacio> GetAll();
    }
}