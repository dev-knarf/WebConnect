using Spring.Context;
using Spring.Context.Support;

namespace WebConnect.Core
{
    public class AppCtx
    {
        private static AppCtx _instance;
        private readonly IApplicationContext _application;

        private static AppCtx Instance => _instance ?? (_instance = new AppCtx());
        
        private AppCtx() => _application = ContextRegistry.GetContext();

        public static object Resolve(string name) => Instance._application.GetObject(name); 

        public static T Resolve<T>(string name) => (T)Instance._application.GetObject(name);

        public static T Resolve<T>() => (T)Instance._application.GetObject(typeof(T).Name);
    }
}