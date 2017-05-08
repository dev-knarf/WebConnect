using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public interface ITipoDependenciaComponent
    {
        void Insert(TipoDependencia obj);
        void Update(TipoDependencia obj);
        TipoDependencia GetById(int value);
        IList<TipoDependencia> GetAll();
    }
}