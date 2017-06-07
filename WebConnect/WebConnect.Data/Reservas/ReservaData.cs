using System;
using System.Collections.Generic;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Utility;

namespace WebConnect.Data.Reservas
{
    public class ReservaData : AbstractData<Reserva, int>, IReservaData
    {
        [Transaction(ReadOnly = true)]
        public IList<Reserva> GetByFechaAndEspacio(DateTime date, int value)
        {
            return Session.QueryOver<Reserva>()
                          .Where(r => r.Fecha.Date == date.Date && r.Espacio.ObjectId == value)
                          .List();
        }

        [Transaction(ReadOnly = true)]
        public IList<Reserva> GetByFilter(Filter filter)
        {
            var query = Session.CreateCriteria(typeof(Reserva));
            switch (filter.ByDate.Type)
            {
                case DateFilter.Today:
                    query.Add(Restrictions.Eq("Fecha", filter.ByDate.StartDate));
                    break;
                case DateFilter.AfterTo:
                    query.Add(Restrictions.Le("Fecha", filter.ByDate.StartDate));
                    break;
                case DateFilter.BeforeTo:
                    query.Add(Restrictions.Ge("Fecha", filter.ByDate.StartDate));
                    break;
                case DateFilter.Between:
                    query.Add(Restrictions.Ge("Fecha", filter.ByDate.StartDate));
                    query.Add(Restrictions.Le("Fecha", filter.ByDate.EndDate));
                    break;
            }

            if (filter.ByDependencia != 0)
                query.Add(Restrictions.Eq("Dependencia.ObjectId", filter.ByDependencia));

            if (filter.ByEspacio != 0)
                query.Add(Restrictions.Eq("Espacio.ObjectId", filter.ByEspacio));

            query.AddOrder(Order.Desc("Fecha"))
                 .AddOrder(Order.Asc("HoraInicio.ObjectId"));

            return query.List<Reserva>();
        }

        [Transaction(ReadOnly = true)]
        public override IList<Reserva> GetAll()
        {
            return Session.QueryOver<Reserva>()
                          .OrderBy(r => r.Fecha).Desc
                          .ThenBy(r => r.HoraInicio.ObjectId).Asc
                          .List<Reserva>();
        }
    }
}