using System.Collections.Generic;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas.Compuestos
{
    public class HoraService : AbstractService<IHoraComponent>, IHoraService
    {
        public Hora GetById(IntValue param) => Invoke().GetById(param.Value);

        public IList<Hora> GetAll() => Invoke().GetAll();
    }
}