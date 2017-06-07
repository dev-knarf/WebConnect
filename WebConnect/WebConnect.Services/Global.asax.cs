using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using WebConnect.Services.Reservas;
using WebConnect.Services.Reservas.Compuestos;
using WebConnect.Services.Security;

namespace WebConnect.Services
{
    public class Global : HttpApplication
    {
        private static void LoadRoute<TService, TSecurity>(string app) where TSecurity : ServiceHostFactoryBase
        {
            var objType = typeof(TService);
            var appdir = string.IsNullOrEmpty(app) ? $"{objType.Name}" : $"{app}/{objType.Name}";
            RouteTable.Routes.Add(new ServiceRoute(appdir, (TSecurity) Activator.CreateInstance(typeof(TSecurity)), objType));
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            //namespace WebConnect.Services.Reservas.Compuestos
            LoadRoute<ClaseDependenciaService, UnsecureServiceFactory>(App.Siades);
            LoadRoute<EstadoService, UnsecureServiceFactory>(App.Siades);
            LoadRoute<TipoDependenciaService, UnsecureServiceFactory>(App.Siades);

            //namespace WebConnect.Services.Reservas
            LoadRoute<DependenciaService, UnsecureServiceFactory>(App.Siades);
            LoadRoute<EspacioService, UnsecureServiceFactory>(App.Siades);
            LoadRoute<HoraService, UnsecureServiceFactory>(App.Siades);
            LoadRoute<ReservaService, UnsecureServiceFactory>(App.Siades);

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