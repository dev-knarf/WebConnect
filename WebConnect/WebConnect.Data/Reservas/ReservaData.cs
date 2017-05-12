using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Data.Reservas
{
    public class ReservaData : AbstractData<Reserva, int>, IReservaData
    {
        public IList<Reserva> GetByFechaAndEspacio(DateTime date, int value)
        {
            return Session.QueryOver<Reserva>()
                          .Where(r => r.FechaSolicitud.Date == date.Date && r.Espacio.ObjectId == value)
                          .List();
        }
    }
}