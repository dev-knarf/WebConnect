using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web.Http.Cors;
using WebConnect.Data.Model.Reservas;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas
{
    [ServiceContract(Namespace = "http://WebConnect.Services.Reservas")]
    public interface IEspacioService
    {
        [OperationContract]
        //[EnableCors(methods: "POST", headers: "*", origins: "*")]
        [WebInvoke(Method = "POST", UriTemplate = "GetById", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Espacio GetById(IntValue param);

        [OperationContract]
        //[EnableCors(methods: "GET", headers: "*", origins: "*")]
        [WebInvoke(Method = "GET", UriTemplate = "GetAll", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IList<Espacio> GetAll();
    }
}