using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture()]
    public class TipoDependenciaTest : AbstractTest<ITipoDependenciaComponent>
    {
        [Test]
        public void CreateTipo()
        {
            var tipo1 = new TipoDependencia {Nombre = "Académica" };
            var tipo2 = new TipoDependencia { Nombre = "Adminstrativa" };
            Invoke().Insert(tipo1);
            Invoke().Insert(tipo2);
        }

        [Test]
        public void UpdateTipo()
        {
            var tipo1 = Invoke().GetById(13);
            tipo1.Nombre = "Administrativa";
            Invoke().Update(tipo1);
        }

        [Test]
        public void GetAllTipo()
        {
            Invoke().GetAll().ToList().ForEach(t => Console.WriteLine(t.Nombre));
        }
    }
}