using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Reservas;

namespace WebConnect.Components.Reservas
{
    public class EspacioComponent : AbstractComponent<IEspacioData>, IEspacioComponent
    {
        public void Insert(Espacio obj)
        {
            if(obj is null)  throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public void Update(Espacio obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Update(obj);
        }

        public Espacio GetById(int value) => Invoke().GetById(value);

        public IList<Espacio> GetAll() => Invoke().GetAll();
    }
}