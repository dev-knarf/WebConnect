using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Security;
using WebConnect.Data.Security;

namespace WebConnect.Components.Security
{
    public class LogComponent : AbstractComponent<ILogData>, ILogComponent
    {
        public void Insert(Log obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            Invoke().Save(obj);
        }

        public Log GetById(int value) => Invoke().GetById(value);

        public IList<Log> GetByToken(string token) => Invoke().GetByToken(token);

        public IList<Log> GetByDate(DateTime date) => Invoke().GetByDate(date);

        public IList<Log> GetAll() => Invoke().GetAll();

    }
}