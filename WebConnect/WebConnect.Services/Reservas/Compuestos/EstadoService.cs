using System.Collections.Generic;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas.Compuestos
{
    public class EstadoService : AbstractService<IEstadoComponent>, IEstadoService
    {
        public Estado GetById(IntValue param)  => Invoke().GetById(param.Value);

        public IList<Estado> GetAll() => Invoke().GetAll();
        
    }
}