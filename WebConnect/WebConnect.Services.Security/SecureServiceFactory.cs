using Microsoft.ServiceModel.Web;
using System;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace WebConnect.Services.Security
{
    public class SecureServiceFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            var hostApp = new WebServiceHost2(serviceType, true, baseAddresses);
            //hostApp.Interceptors.Add();
            return hostApp;
        }
    }
}
