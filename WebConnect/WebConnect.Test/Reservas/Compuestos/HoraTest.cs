using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using NUnit.Framework;
using WebConnect.Components.Reservas;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture]
    public class HoraTest : AbstractTest<IHoraComponent>
    {
        [Test]
        public void CreateHora()
        {
            var formato = "hh:mm tt";
            var h24 = "HH:mm";
            var time = string.Empty;
            var lista = new List<string>();
            var hora = new DateTime(2017, 5, 8, 6, 0, 0, DateTimeKind.Utc);
            while (hora.ToString(h24).Trim() != "22:30")
            {
                time = hora.ToString(formato, CultureInfo.InvariantCulture);
                Console.WriteLine(time);
                lista.Add(time);
                //Invoke().Insert(new Hora{Tiempo = time});
                hora = hora.AddMinutes(30);
            } 
        }

        [Test]
        public void GetAllHoras()
        {
            Invoke().GetAll().ToList().ForEach(h => Console.WriteLine(h.Tiempo));
        }

        [Test]
        public void GetByIdHoras()
        {
            Console.WriteLine(Invoke().GetById(5).Tiempo);
        }

    }
}