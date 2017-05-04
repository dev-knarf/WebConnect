using System.Collections.Generic;
using WebConnect.Data.Model;

namespace WebConnect.Data.Support
{
    public interface ISupportSearch<TObj, in TId> : IBaseSupport where TObj : AbstractModel
    {
        TObj GetById(TId idObj);
        IList<TObj> GetAll();
    }
}