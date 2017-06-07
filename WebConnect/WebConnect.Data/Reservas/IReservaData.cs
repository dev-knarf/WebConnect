using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Utility;
using WebConnect.Data.Support;

namespace WebConnect.Data.Reservas
{
    public interface IReservaData : ISupportSave<Reserva>, ISupportUpdate<Reserva>, ISupportSearch<Reserva, int>
    {
        IList<Reserva> GetByFechaAndEspacio(DateTime date, int value);
        IList<Reserva> GetByFilter(Filter filter);
    }
}