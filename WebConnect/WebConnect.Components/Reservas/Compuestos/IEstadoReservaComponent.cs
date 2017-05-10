using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public interface IEstadoReservaComponent
    {
        void Insert(EstadoReserva obj);
        void Update(EstadoReserva obj);
        EstadoReserva GetById(int value);
        IList<EstadoReserva> GetAll();
    }
}