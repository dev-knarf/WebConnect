using System.Collections.Generic;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas.Compuestos
{
    public class TipoDependenciaService : AbstractService<ITipoDependenciaComponent>, ITipoDependenciaService
    {
        public TipoDependencia GetById(IntValue param) => Invoke().GetById(param.Value);

        public IList<TipoDependencia> GetAll() => Invoke().GetAll();

    }
}