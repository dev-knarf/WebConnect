using System.Collections.Generic;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Components.Reservas.Compuestos
{
    public interface ITipoSalaComponent
    {
        void Insert(TipoSala obj);
        void Update(TipoSala obj);
        TipoSala GetById(int value);
        IList<TipoSala> GetAll();
    }
}