using System;
using WebConnect.Data.Model.Reservas.Compuestos;

namespace WebConnect.Data.Model.Reservas
{
    public class Reserva : AbstractModel
    {
        public Dependencia Dependencia { get; set; }
        public Hora HoraInicio { get; set; }
        public Hora HoraFin { get; set; }
        public Espacio Espacio { get; set; }
        //public Hora Usuario { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Solicita { get; set; }
        public string Responsable { get; set; }
        public string Actividad { get; set; }
        public string Email { get; set; }
        public string Observacion { get; set; }
        public EstadoReserva Estado { get; set; }
    }
}