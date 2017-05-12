using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public class TipoDependenciaComponent : AbstractComponent<ITipoDependenciaData>, ITipoDependenciaComponent
    {
        public void Insert(TipoDependencia obj)
        {
            if(obj is null) throw  new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public void Update(TipoDependencia obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Update(obj);
        } 

        public TipoDependencia GetById(int value) => Invoke().GetById(value);
        
        public IList<TipoDependencia> GetAll() => Invoke().GetAll();
        
    }
}