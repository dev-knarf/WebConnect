using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Data.Model.Reservas
{
    public class Dependencia : AbstractModel 
    {
        public virtual string Nombre { get; set; }
        public virtual TipoDependencia Tipo { get; set; }
        public virtual ClaseDependencia Clase { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
