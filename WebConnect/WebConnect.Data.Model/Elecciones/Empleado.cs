using WebConnect.Data.Model.Elecciones.Compuestos;
using WebConnect.Data.Model.Elecciones.Types;

namespace WebConnect.Data.Model.Elecciones
{
    public class Empleado : AbstractModel
    {
        private string FkCentroCosto { get; set; }
        //--
        public string Nit { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Empresa { get; set; }
        public CentroCosto CentroCosto { get; set; }
        public Estado Estado { get; set; }
    }
}
