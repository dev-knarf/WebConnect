using WebConnect.Data.Model.Elecciones.Types;

namespace WebConnect.Data.Model.Elecciones.Compuestos
{
    public class CentroCosto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public TipoCentro Tipo { get; set; }
        public Estado Estado { get; set; }
    }
}