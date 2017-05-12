using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public class EstadoReservaComponent : AbstractComponent<IEstadoReservaData>, IEstadoReservaComponent
    {
        public void Insert(EstadoReserva obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public void Update(EstadoReserva obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Update(obj);
        }

        public EstadoReserva GetById(int value) => Invoke().GetById(value);

        public IList<EstadoReserva> GetAll() => Invoke().GetAll();
    }
}