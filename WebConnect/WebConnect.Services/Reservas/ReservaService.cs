using System.Collections.Generic;
using WebConnect.Components.Reservas;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Utility;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas
{
    public class ReservaService : AbstractService<IReservaComponent>, IReservaService
    {
        public Reserva GetById(IntValue param) => Invoke().GetById(param.Value);

        public IList<Reserva> GetAll() => Invoke().GetAll();

        public IList<Reserva> GetByFilter(Filter filter) => Invoke().GetByFilter(filter);

    }
}