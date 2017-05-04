using System.Collections.Generic;
using WebConnect.Data.Model;

namespace WebConnect.Data.Support
{
    public interface ISupportDelete<TObj, in TId> : IBaseSupport where TObj : AbstractModel
    {
        void Delete(TId idObj);
        void Delete(TObj obj);
        void Delete(IList<TObj> listObj);
    }
}