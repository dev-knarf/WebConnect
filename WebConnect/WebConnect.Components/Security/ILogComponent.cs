using System;
using System.Collections.Generic;
using WebConnect.Data.Model.Security;

namespace WebConnect.Components.Security
{
    public interface ILogComponent
    {
        void Insert(Log obj);
        Log GetById(int value);
        IList<Log> GetByToken(string token);
        IList<Log> GetByDate(DateTime date);
        IList<Log> GetAll();
    }
}