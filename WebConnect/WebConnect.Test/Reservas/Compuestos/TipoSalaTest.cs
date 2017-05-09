using System;
using System.Linq;
using NUnit.Framework;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Test.Reservas.Compuestos
{
    [TestFixture]
    public class TipoSalaTest : AbstractTest<ITipoSalaComponent>
    {
        [Test]
        public void CreateTipoSala()
        {
            var ts = new TipoSala{ Descripcion = "LABORATORIO"};
            Invoke().Insert(ts);
        }

        [Test]
        public void UpdateTipoSala()
        {
            var ts = Invoke().GetById(3);
            ts.Descripcion = "SALA DE SISTEMA";
            Invoke().Update(ts);
        }

        [Test]
        public void GetByIdTipoSala()
        {
            //var ts = new TipoSala { Descripcion = "AUDITORIO" };
            //Invoke().Insert(ts);
        }

        [Test]
        public void GetAllTipoSala()
        {
            Invoke().GetAll().ToList().ForEach(ts => Console.WriteLine( ts.Descripcion));
        }
    }
}