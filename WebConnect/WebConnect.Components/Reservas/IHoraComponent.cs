using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Components.Reservas
{
    public interface IHoraComponent
    {
        void Insert(Hora obj);
        Hora GetById(int value);
        IList<Hora> GetAll();
    }
}