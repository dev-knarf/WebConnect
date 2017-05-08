using System.Collections.Generic;

namespace WebConnect.Services.Utility
{
    public abstract class GenericValue <TValue>
    {
        public TValue Value { get; set; }
    }

    public class IntValue : GenericValue<int> {}
    public class DoubleValue : GenericValue<double> { }
    public class FloatValue : GenericValue<float> { }
    public class StringValue : GenericValue<string> { }
    public class ListValue : GenericValue<IList<KeyValuePair<string, string>>> { }
}