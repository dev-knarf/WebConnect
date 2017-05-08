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
        public void Insert(ClaseDependencia obj, Log log)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));
            if (log == null) throw new ArgumentNullException(nameof(log));
            Invoke().Save(obj);
            Invoke<ILogData>().Save(log);
        }

        public void Update(ClaseDependencia obj, Log log)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            if (log == null) throw new ArgumentNullException(nameof(log));
            Invoke().Update(obj);
        }

        public ClaseDependencia GetById(int value) => Invoke().GetById(value);

        public IList<ClaseDependencia> GetAll() => Invoke().GetAll();
        
    }
}