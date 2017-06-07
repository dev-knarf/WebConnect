using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NUnit.Framework;
using WebConnect.Components.Reservas;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Utility;

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
                Fecha = new DateTime(2017,05, 11),
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

        [Test]
        public void ReservaByFilter()
        {
            var obj = new Filter
            {
                ByDate = new Date
                {
                    Type = DateFilter.Between,
                    StartDate = new DateTime(2017, 05, 11),
                    EndDate = new DateTime(2017, 05, 12)
                },
                ByDependencia = 0,
                ByEspacio = 0
            };
            Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented, new JavaScriptDateTimeConverter()));
            
            var list = Invoke().GetByFilter(obj);
            Console.WriteLine(list.Count);
            Console.WriteLine("");
            Console.WriteLine(JsonConvert.SerializeObject(list));
        }

    }
}