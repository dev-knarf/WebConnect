using Spring.Data.NHibernate.Support;
using Spring.Transaction.Interceptor;
using System;
using System.Collections.Generic;
using NHibernate.Util;
using WebConnect.Data.Model;
using WebConnect.Data.Support;

namespace WebConnect.Data
{
    public class AbstractData<TObj, TId> : HibernateDaoSupport, ISupportSave<TObj>, ISupportUpdate<TObj>, ISupportDelete<TObj, TId>, ISupportSearch<TObj, TId> where TObj : AbstractModel
    {
        protected string Query;

        [Transaction(ReadOnly = false)]
        public void Save(TObj obj)
        {
            if(obj is null) 
                throw new ArgumentNullException(nameof(obj));
            HibernateTemplate.Save(obj); 
        }

        [Transaction(ReadOnly = false)]
        public void Save(IList<TObj> listObj)
        {
            if (listObj is null)
                throw new ArgumentNullException(nameof(listObj));
            listObj.ForEach(Save);
        }

        [Transaction(ReadOnly = false)]
        public void Update(TObj obj)
        {
            if (obj is null)
                throw new ArgumentNullException(nameof(obj));
            HibernateTemplate.Update(obj);
        }

        [Transaction(ReadOnly = false)]
        public void Update(IList<TObj> listObj)
        {
            if (listObj is null)
                throw new ArgumentNullException(nameof(listObj));
            listObj.ForEach(Update);
        }

        [Transaction(ReadOnly = false)]
        public void Delete(TObj obj)
        {
            if (obj is null)
                throw new ArgumentNullException(nameof(obj));
            HibernateTemplate.Delete(obj);
        }

        [Transaction(ReadOnly = false)]
        public void Delete(TId idObj)
        {
            HibernateTemplate.Delete(GetById(idObj));
        }

        [Transaction(ReadOnly = false)]
        public void Delete(IList<TObj> listObj)
        {
            if (listObj is null)
                throw new ArgumentNullException(nameof(listObj));
            listObj.ForEach(Delete);
        }

        [Transaction(ReadOnly = true)]
        public TObj GetById(TId idObj) => Session.Get<TObj>(idObj);
        
        [Transaction(ReadOnly = true)]
        public IList<TObj> GetAll() => Session.CreateCriteria<TObj>().List<TObj>();

    }
}
