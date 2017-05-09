using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public class HoraComponent : AbstractComponent<IHoraData>, IHoraComponent
    {
        public void Insert(Hora obj)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public Hora GetById(int value) => Invoke().GetById(value);

        public IList<Hora> GetAll() => Invoke().GetAll();
    }
}