using WebConnect.Components.Security;
using WebConnect.Core;

namespace WebConnect.Components
{
    public abstract class AbstractComponent
    {
    }

    public abstract class AbstractComponent<TObj> where TObj : class
    {
        protected ILogComponent Logger { get; set; }
        
        public TObj Invoke() => AppCtx.Resolve<TObj>();
        public T Invoke<T>() => AppCtx.Resolve<T>();
    }
}
