using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Utility;

namespace WebConnect.Components.Reservas
{
    public interface IReservaComponent
    {
        void Insert(Reserva obj);
        void Update(Reserva obj);
        Reserva GetById(int value);
        IList<Reserva> GetByFilter(Filter filter);
        IList<Reserva> GetAll();
    }
}