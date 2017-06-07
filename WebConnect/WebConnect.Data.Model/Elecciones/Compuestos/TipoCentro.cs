using WebConnect.Data.Model.Elecciones.Types;

namespace WebConnect.Data.Model.Elecciones.Compuestos
{
    public class TipoCentro : AbstractModel
    {
        public string Nombre { get; set; }
        public Estado Estado { get; set; }
    }
}
