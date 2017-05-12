using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Reservas;

namespace WebConnect.Components.Reservas
{
    public class DependenciaComponent : AbstractComponent<IDependenciaData>, IDependenciaComponent
    {
        public void Insert(Dependencia obj)
        {
            if(obj is null) throw new ArgumentNullException();
            Invoke().Save(obj);
        }

        public void Update(Dependencia obj)
        {
            if (obj is null) throw new ArgumentNullException();
            Invoke().Update(obj);
        }

        public Dependencia GetById(int value) => Invoke().GetById(value);

        public IList<Dependencia> GetAll() => Invoke().GetAll();
    }
}