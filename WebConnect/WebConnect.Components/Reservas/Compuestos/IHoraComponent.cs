using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public interface IHoraComponent
    {
        void Insert(Hora obj);
        Hora GetById(int value);
        IList<Hora> GetAll();
    }
}