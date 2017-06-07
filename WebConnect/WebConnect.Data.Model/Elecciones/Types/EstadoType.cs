using NHibernate.Type;

namespace WebConnect.Data.Model.Elecciones.Types
{
    public enum Estado
    {
        I,
        A,
        R 
    }

    public class EstadoType : EnumStringType<Estado> {}
}