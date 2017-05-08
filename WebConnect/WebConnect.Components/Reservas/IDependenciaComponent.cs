using System.Collections.Generic;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Components.Reservas
{
    public interface IDependenciaComponent
    {
        void Insert(Dependencia obj);
        void Update(Dependencia obj);
        Dependencia GetById(int value);
        IList<Dependencia> GetAll();
    }
}