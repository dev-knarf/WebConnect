using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Security;
using WebConnect.Data.Support;

namespace WebConnect.Data.Security
{
    public interface ILogData : ISupportSave<Log>, ISupportSearch<Log, int>
    {
        IList<Log> GetByToken(string token);
        IList<Log> GetByDate(DateTime date);
    }
}