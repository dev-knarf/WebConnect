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
            var espacio = new Espacio
            {
                Capacidad = 25,
                Nombre = "Sala 1",
                Descripcion = "Sala con 25 PC, y el equipo del docente para un total de 26 equipos.",
                Estado = Invoke<IEstadoComponent>().GetById(1),
                Tipo = Invoke<ITipoSalaComponent>().GetById(3)
            };
            Invoke().Insert(espacio);
        }
    }
}