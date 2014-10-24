using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Number
{
    public class HexFormatProvider : IFormatProvider, ICustomFormatter
    {

        IFormatProvider _parent;   // Allows consumers to chain format providers

        public HexFormatProvider() : this(CultureInfo.CurrentCulture) { }
        public HexFormatProvider(IFormatProvider parent)
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
            if (arg == null || format != "Hex")
                return string.Format(_parent, "{0:" + format + "}", arg);
            StringBuilder result = new StringBuilder();
            result.Append(PRepresentationOfNumber.TransferredToAnotherNumberSystem((int)arg, 16));
            return result.ToString();
        }
    }
}