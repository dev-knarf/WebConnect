using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Reservas;

namespace WebConnect.Components.Reservas
{
    public class HoraComponent : AbstractComponent<IHoraData>, IHoraComponent
    {
        public void Insert(Hora obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public Hora GetById(int value) => Invoke().GetById(value);

        public IList<Hora> GetAll() => Invoke().GetAll();
    }
}