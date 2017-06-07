using System;

namespace WebConnect.Data.Model.Utility
{
    public enum DateFilter
    {
        Today = 0,
        AfterTo,
        BeforeTo,
        Between
    }

    public class Filter
    {
        public Filter()
        {
            ByDate = new Date();
        }

        public Date ByDate { get; set; }
        public int ByDependencia { get; set; }
        public int ByEspacio { get; set; }
    }

    public class Date
    {
        public DateFilter Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
