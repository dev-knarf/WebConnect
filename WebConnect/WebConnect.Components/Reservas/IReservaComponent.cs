using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Components.Reservas
{
    public interface IReservaComponent
    {
        void Insert(Reserva obj);
        void Update(Reserva obj);
        Reserva GetById(int value);
        IList<Reserva> GetAll();
    }
}