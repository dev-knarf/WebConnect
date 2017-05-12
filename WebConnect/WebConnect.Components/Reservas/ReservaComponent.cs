using System;
using System.Collections.Generic;
using System.Linq;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Reservas;

namespace WebConnect.Components.Reservas
{
    public class ReservaComponent : AbstractComponent<IReservaData>, IReservaComponent
    {
        public void Insert(Reserva obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            var message = string.Empty;
            var list = (List<Reserva>)Invoke().GetByFechaAndEspacio(obj.FechaSolicitud, obj.Espacio.ObjectId);

            if (list != null)
            {
                var filter = list.Where(r => r.HoraInicio.ObjectId == obj.HoraInicio.ObjectId)
                                 .ToList();
                if (filter.Any()) ErrorException(filter);

                filter = list.Where(r => r.HoraInicio.ObjectId < obj.HoraInicio.ObjectId && obj.HoraInicio.ObjectId < r.HoraFin.ObjectId
                                      || r.HoraInicio.ObjectId < obj.HoraFin.ObjectId && obj.HoraFin.ObjectId < r.HoraFin.ObjectId)
                             .ToList();
                if (filter.Any()) ErrorException(filter);

                //if (error)
                //{
                //    filter.ToList()
                //        .ForEach(r => message +=
                //            $"\t - RECORD_ID:{r.ObjectId}, DATE:{r.FechaSolicitud.ToShortDateString()}, TIME:{r.HoraInicio.Tiempo} - {r.HoraFin.Tiempo}, ROOM:{r.Espacio.Nombre}\r");
                //    throw new Exception($"Se ha(n) presentado cruce con la(s) siguiente(s) reserva(s):\r{message}");
                //}
            }
            Invoke().Save(obj);

            void ErrorException(IEnumerable<Reserva> filter)
            {
                filter.ToList()
                      .ForEach(r => message += $"\t - RECORD_ID:{r.ObjectId}, DATE:{r.FechaSolicitud.ToShortDateString()}, TIME:{r.HoraInicio.Tiempo} - {r.HoraFin.Tiempo}, ROOM:{r.Espacio.Nombre}\r");
                throw new Exception($"Se ha(n) presentado cruce con la(s) siguiente(s) reserva(s):\r{message}");
            }
        }

        public void Update(Reserva obj)
        {
            if (obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Update(obj);
        }

        public Reserva GetById(int value) => Invoke().GetById(value);

        public IList<Reserva> GetAll() => Invoke().GetAll();
    }
}