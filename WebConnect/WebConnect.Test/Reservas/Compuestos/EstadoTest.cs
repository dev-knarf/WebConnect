using System;
using NUnit.Framework;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture]
    public class EstadoTest : AbstractTest<IEstadoComponent>
    {
        [Test]
        public void CreateEstado()
        {
            var estado = new Estado
            {
                Nombre = "ACTIVO"
            };
            Invoke().Insert(estado);
        }

        [Test]
        public void UpdateEstado()
        {
            var x = Invoke().GetById(1);
            x.Nombre = "CHANGE NAME 33";
            Invoke().Update(x);
        }

        [Test]
        public void GetAllEstado()
        {
            foreach (var estado in Invoke().GetAll())
                Console.WriteLine(estado.Nombre);
        }
    }
}