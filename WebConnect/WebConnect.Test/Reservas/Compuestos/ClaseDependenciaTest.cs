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
            var clase = new ClaseDependencia {Nombre = "VICERRECTORIA"};
            var log = new Log
            {
                Token = "12345569ABSCD7412589A",
                Url = "ClaseDependencia/Create",
                Body = clase.ToString()
            };
            Invoke().Insert(clase, log);
        }

        [Test]
        public void GetAllClase()
        {
            foreach (var item in Invoke().GetAll())
                Console.WriteLine(item.Nombre);
        }

    }
}