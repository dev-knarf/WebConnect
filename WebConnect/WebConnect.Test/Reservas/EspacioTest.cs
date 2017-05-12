using System;
using System.Text;
using NUnit.Framework;
using WebConnect.Components.Reservas;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Test.Reservas
{
    [TestFixture]
    public class EspacioTest : AbstractTest<IEspacioComponent>
    {
        [Test]
        public void CreateEspacio()
        {
            var espacio1 = new Espacio
            {
                Capacidad = 25,
                Nombre = "Sala 2",
                Descripcion = "Sala con 25 PC, y el equipo del docente para un total de 26 equipos.",
                Estado = Invoke<IEstadoComponent>().GetById(5),
                Tipo = Invoke<ITipoSalaComponent>().GetById(3)
            };
            var espacio2 = new Espacio
            {
                Capacidad = 25,
                Nombre = "Sala 3",
                Descripcion = "Sala con 25 PC, y el equipo del docente para un total de 26 equipos.",
                Estado = Invoke<IEstadoComponent>().GetById(5),
                Tipo = Invoke<ITipoSalaComponent>().GetById(3)
            };
            var espacio3 = new Espacio
            {
                Capacidad = 25,
                Nombre = "Sala 4",
                Descripcion = "Sala con 25 PC, y el equipo del docente para un total de 26 equipos.",
                Estado = Invoke<IEstadoComponent>().GetById(5),
                Tipo = Invoke<ITipoSalaComponent>().GetById(3)
            };
            Invoke().Insert(espacio1);
            Invoke().Insert(espacio2);
            Invoke().Insert(espacio3);
        }

        //[Test]
        //public void Test()
        //{
        //    Console.WriteLine(Encoding.Default.GetString(Convert.FromBase64String("a3f9e324-a345-439f-af9a-1d795431d3c8")));
        //}

    }
}