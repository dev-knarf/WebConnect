using System.Collections.Generic;
using WebConnect.Components.Reservas;
using WebConnect.Data.Model.Reservas;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas
{
    public class EspacioService : AbstractService<IEspacioComponent>, IEspacioService
    {
        public Espacio GetById(IntValue param) => Invoke().GetById(param.Value);

        public IList<Espacio> GetAll() => Invoke().GetAll();
    }
}