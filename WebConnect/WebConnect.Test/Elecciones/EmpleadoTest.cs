using System;
using Newtonsoft.Json;
using NUnit.Framework;
using WebConnect.Components.Elecciones;

namespace WebConnect.Test.Elecciones
{
    [TestFixture]
    public class EmpleadoTest : AbstractTest<IEmpleadoComponent>
    {
        [Test]
        public void GetByNit()
        {
            var emp = Invoke().GetByNit("8854411");
            Console.WriteLine(JsonConvert.SerializeObject(emp));
        }
    }
}