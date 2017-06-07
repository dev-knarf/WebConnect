using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WebConnect.Data.Model.Reservas;
using WebConnect.Data.Model.Utility;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas
{
    [ServiceContract(Namespace = "http://WebConnect.Services.Reservas")]
    public interface IReservaService
    {
        [OperationContract]
        //[EnableCors(methods: "POST", headers: "*", origins: "*")]
        [WebInvoke(Method = "POST", UriTemplate = "GetById", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Reserva GetById(IntValue param);

        [OperationContract]
        //[EnableCors(methods:"POST", headers: "*", origins:"*")]
        [WebInvoke(Method = "POST", UriTemplate = "GetAll", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        IList<Reserva> GetAll();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GetByFilter", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        IList<Reserva> GetByFilter(Filter filter);
    }
}