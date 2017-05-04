using System.Collections.Generic;
using WebConnect.Data.Model;

namespace WebConnect.Data.Support
{
   public interface ISupportSave<TObj> : IBaseSupport where TObj : AbstractModel
    {
        void Save(TObj obj);
        void Save(IList<TObj> listObj);
    }
}