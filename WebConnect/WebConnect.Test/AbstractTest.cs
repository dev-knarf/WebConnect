using WebConnect.Core;

namespace WebConnect.Test
{
    public abstract class AbstractTest<TObj>
    {
        public TObj Invoke() => AppCtx.Resolve<TObj>();

        public T Invoke<T>() => AppCtx.Resolve<T>();
    }
}