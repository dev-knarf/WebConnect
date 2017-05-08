using System;
using NUnit.Framework;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture]
    public class ClaseDependenciaTest : AbstractTest<IClaseDependenciaComponent>
    {
        [Test]
        public void CreateClase()
        {
            var clase = new ClaseDependencia
            {
                Nombre = "VICERRECTORIA"
            };
            Invoke().Insert(clase);
        }

        [Test]
        public void GetAllClase()
        {
            foreach (var item in Invoke().GetAll())
                Console.WriteLine(item.Nombre);
        }

    }
}