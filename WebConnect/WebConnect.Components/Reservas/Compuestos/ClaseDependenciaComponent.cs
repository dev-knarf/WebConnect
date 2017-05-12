using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Model.Security;
using WebConnect.Data.Reservas.Compuestos;
using WebConnect.Data.Security;

namespace WebConnect.Components.Reservas.Compuestos
{
    public class ClaseDependenciaComponent : AbstractComponent<IClaseDependenciaData>, IClaseDependenciaComponent
    {
        public void Insert(ClaseDependencia obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public void Update(ClaseDependencia obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Update(obj);
        }

        public ClaseDependencia GetById(int value) => Invoke().GetById(value);

        public IList<ClaseDependencia> GetAll() => Invoke().GetAll();
        
    }
}