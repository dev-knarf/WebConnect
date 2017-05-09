using System.Collections.Generic;
using WebConnect.Components.Reservas;
using WebConnect.Data.Model.Reservas;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas
{
    public class HoraService : AbstractService<IHoraComponent>, IHoraService
    {
        public Hora GetById(IntValue param) => Invoke().GetById(param.Value);

        public IList<Hora> GetAll() => Invoke().GetAll();
    }
}