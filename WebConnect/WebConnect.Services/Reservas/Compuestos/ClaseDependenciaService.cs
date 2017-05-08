using System;
using System.Collections.Generic;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas.Compuestos
{
    public class ClaseDependenciaService : AbstractService<IClaseDependenciaComponent>, IClaseDependenciaService
    {
        public ClaseDependencia GetById(IntValue param) => Invoke().GetById(param.Value);
        
        public IList<ClaseDependencia> GetAll() => Invoke().GetAll();
    }
}