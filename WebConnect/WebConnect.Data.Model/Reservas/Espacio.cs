using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Data.Model.Reservas
{
    public class Espacio : AbstractModel
    {
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public TipoSala Tipo { get; set; }
        public Estado Estado { get; set; }
        public string Descripcion { get; set; }
    }
}