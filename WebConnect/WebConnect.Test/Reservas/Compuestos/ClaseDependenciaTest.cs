using System;
using System.Linq;
using NUnit.Framework;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Reservas.Compuestos;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture]
    public class ClaseDependenciaTest : AbstractTest<IClaseDependenciaData>
    {
        [Test]
        public void CreateClase()
        {
            var clase = new ClaseDependencia
            {
                Nombre = "VICERRECTORIA"
            };
            Invoke().Save(clase);
        }

        [Test]
        public void GetAllClase()
        {
            foreach (var item in Invoke().GetAll())
                Console.WriteLine(item.Nombre);
        }

    }
}