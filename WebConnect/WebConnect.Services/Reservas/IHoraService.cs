﻿using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WebConnect.Data.Model.Reservas;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas
{
    [ServiceContract(Namespace = "http://WebConnect.Services.Reservas.Compuestos")]
    public interface IHoraService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GetById", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Hora GetById(IntValue param);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetAll", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IList<Hora> GetAll();
    }
}