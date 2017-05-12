using System;
using NUnit.Framework;
using WebConnect.Components.Reservas;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Test.Reservas
{
    [TestFixture]
    public class ReservaTest : AbstractTest<IReservaComponent>
    {
        [Test]
        public void ReservaSave()
        {
            var reserva1 = new Reserva
            {
                FechaSolicitud = new DateTime(2017,05, 11),
                HoraInicio = Invoke<IHoraComponent>().GetById(3),
                HoraFin = Invoke<IHoraComponent>().GetById(5),
                Espacio = Invoke<IEspacioComponent>().GetById(1),
                Dependencia = Invoke<IDependenciaComponent>().GetById(4),
                Solicita = "Oscar Becerra",
                Email = "obecerra@usbctg.edu.co",
                Responsable = "Oscar Becerra",
                Actividad = "Clases",
                Estado = Invoke<IEstadoReservaComponent>().GetById(15)
            };
            Invoke().Insert(reserva1);
        }

        [Test]
        public void ReservaById()
        {
            var obj = Invoke().GetById(1);
            Console.WriteLine(obj.ToString());
        }
    }
}