using NUnit.Framework;
using WebConnect.Components.Reservas;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Data.Model.Reservas;

namespace WebConnect.Test.Reservas
{
    [TestFixture]
    public class DependenciaTest : AbstractTest<IDependenciaComponent>
    {
        [Test]
        public void CreateDependencia()
        {
            var dep = new Dependencia
            {
                Nombre = "Biblioteca",
                Estado = Invoke<IEstadoComponent>().GetById(1),
                Clase = Invoke<IClaseDependenciaComponent>().GetById(4),
                Tipo = Invoke<ITipoDependenciaComponent>().GetById(2)
            };
            Invoke().Insert(dep);
        }
    }
}
