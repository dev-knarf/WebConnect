using WebConnect.Core;

namespace WebConnect.Components
{
    public abstract class AbstractComponent
    {
        public T Invoke<T>() => AppCtx.Resolve<T>();
    }

    public abstract class AbstractComponent<TObj> where TObj : class
    {
        public TObj Invoke() => AppCtx.Resolve<TObj>();
    }
}
