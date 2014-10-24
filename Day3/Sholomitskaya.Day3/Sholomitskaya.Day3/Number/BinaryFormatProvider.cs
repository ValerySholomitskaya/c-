using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Number
{
    public class BinaryFormatProvider : IFormatProvider, ICustomFormatter
    {

        IFormatProvider _parent;   

        public BinaryFormatProvider() : this(CultureInfo.CurrentCulture) { }
        public BinaryFormatProvider(IFormatProvider parent)
        {
            _parent = parent;
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return null;
        }

        public string Format(string format, object arg, IFormatProvider prov)
        {
            if (arg == null || format != "Bin")
                return string.Format(_parent, "{0:" + format + "}", arg);
            StringBuilder result = new StringBuilder();
            result.Append(PRepresentationOfNumber.TransferredToAnotherNumberSystem((int)arg, 2));
            return result.ToString();
        }
    }
}