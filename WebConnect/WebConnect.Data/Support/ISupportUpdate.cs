using System.Collections.Generic;
using WebConnect.Data.Model;

namespace WebConnect.Data.Support
{
    public interface ISupportUpdate<TObj> : IBaseSupport where TObj : AbstractModel
    {
        void Update(TObj obj);
        void Update(IList<TObj> listObj);
    }
}