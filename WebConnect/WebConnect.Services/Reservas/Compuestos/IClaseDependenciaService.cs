using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas.Compuestos
{
    [ServiceContract(Namespace = "http://WebConnect.Services.Reservas.Compuestos")]
    public interface IClaseDependenciaService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GetById", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        ClaseDependencia GetById(IntValue param);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetAll", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IList<ClaseDependencia> GetAll();
    }
}