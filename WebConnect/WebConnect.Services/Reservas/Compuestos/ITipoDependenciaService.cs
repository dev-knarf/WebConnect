﻿using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using WebConnect.Data.Model.Reservas.Compuestos;
using WebConnect.Services.Utility;

namespace WebConnect.Services.Reservas.Compuestos
{
    [ServiceContract(Namespace = "http://WebConnect.Services.Reservas.Compuestos")]
    public interface ITipoDependenciaService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "GetById", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        TipoDependencia GetById(IntValue param);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetAll", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        IList<TipoDependencia> GetAll();
    }
}