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
            var tipo = new TipoDependencia
            {
                Nombre = "Adminstrativa"
            };
            Invoke().Insert(tipo);
        }
    }
}