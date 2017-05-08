using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public class EstadoComponent : AbstractComponent<IEstadoData>, IEstadoComponent
    {
        public void Insert(Estado obj)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public void Update(Estado obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            Invoke().Update(obj);
        }

        public Estado GetById(int value)
        {
            return Invoke().GetById(value);
        }

        public IList<Estado> GetAll()
        {
            return Invoke().GetAll();
        }
    }
}