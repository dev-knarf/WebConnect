using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public class TipoSalaComponent : AbstractComponent<ITipoSalaData>, ITipoSalaComponent
    {
        public void Insert(TipoSala obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public void Update(TipoSala obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Update(obj);
        }

        public TipoSala GetById(int value) => Invoke().GetById(value);

        public IList<TipoSala> GetAll() => Invoke().GetAll();
    }
}