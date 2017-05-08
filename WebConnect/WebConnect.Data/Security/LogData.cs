using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Security;

namespace WebConnect.Data.Security
{
    public class LogData : AbstractData<Log, int >, ILogData
    {
        public IList<Log> GetByToken(string token)
        {
            return Session.QueryOver<Log>()
                          .Where(s => s.Token == token)
                          .List();
        }

        public IList<Log> GetByDate(DateTime date)
        {
            return Session.QueryOver<Log>()
                          .Where(s => s.CreationDate.Date == date.Date)
                          .List();
        }
    }
}