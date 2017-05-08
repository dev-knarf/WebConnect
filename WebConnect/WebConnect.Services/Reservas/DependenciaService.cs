using System.Collections.Generic;
using WebConnect.Components.Reservas;
using WebConnect.Data.Model.Reservas;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas
{
    public class DependenciaService : AbstractService<IDependenciaComponent>, IDependenciaService
    {
        public Dependencia GetById(IntValue param) => Invoke().GetById(param.Value);

        public IList<Dependencia> GetAll() => Invoke().GetAll();

    }
}