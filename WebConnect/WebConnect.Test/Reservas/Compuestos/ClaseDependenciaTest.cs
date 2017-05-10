using System;
using NUnit.Framework;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Data.Model.Security;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture]
    public class ClaseDependenciaTest : AbstractTest<IClaseDependenciaComponent>
    {
        [Test]
        public void CreateClase()
        {
            var clase1 = new ClaseDependencia { Nombre = "Rectoría" };
            var clase2 = new ClaseDependencia { Nombre = "Vicerrectoría" };
            var clase3 = new ClaseDependencia { Nombre = "Decanatura" };
            var clase4 = new ClaseDependencia { Nombre = "Oficina" };
            var clase5 = new ClaseDependencia { Nombre = "Unidad" };
            Invoke().Insert(clase1);
            Invoke().Insert(clase2);
            Invoke().Insert(clase3);
            Invoke().Insert(clase4);
            Invoke().Insert(clase5);

        }

        [Test]
        public void GetAllClase()
        {
            foreach (var item in Invoke().GetAll())
                Console.WriteLine(item.Nombre);
        }

    }
}