using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using WebConnect.Components.Reservas;
using WebConnect.Components.Reservas.Compuestos;
using WebConnect.Services.Reservas;
using WebConnect.Services.Reservas.Compuestos;
using WebConnect.Services.Security;

namespace WebConnect.Services
{
    public class Global : HttpApplication
    {
        private static void LoadRoute<TService, TSecurity>() where TSecurity : ServiceHostFactoryBase
        {
            var objType = typeof(TService);
            RouteTable.Routes.Add(
                new ServiceRoute(objType.Name, (TSecurity) Activator.CreateInstance(typeof(TSecurity)),
                objType));
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            //namespace WebConnect.Services.Reservas.Compuestos
            LoadRoute<ClaseDependenciaService, UnsecureServiceFactory>();
            LoadRoute<EstadoService, UnsecureServiceFactory>();
            LoadRoute<TipoDependenciaService, UnsecureServiceFactory>();

            //namespace WebConnect.Services.Reservas
            LoadRoute<DependenciaService, UnsecureServiceFactory>();
        }
        
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Origin", "*");
            if (HttpContext.Current.Request.HttpMethod != "OPTIONS") return;
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
            HttpContext.Current.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type, Accept");
            HttpContext.Current.Response.AddHeader("Access-Control-Max-Age", "1728000");
            HttpContext.Current.Response.End();
        }
        
    }
}