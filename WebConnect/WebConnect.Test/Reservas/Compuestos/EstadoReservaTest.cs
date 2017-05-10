using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture]
    public class EstadoReservaTest : AbstractTest<IEstadoReservaComponent>
    {
        [Test]
        public void EstadoReservaSave()
        {
            var list = new List<EstadoReserva>
            {
                new EstadoReserva { Nombre = "Solicitada" },
                new EstadoReserva { Nombre = "Asignada" }
            };
            list.ForEach(e => Invoke().Insert(e));
        }

        [Test]
        public void EstadoReservaGetAll()
        {
            Invoke().GetAll().ToList().ForEach(e => Console.WriteLine(e.Nombre));
        }
    }
}