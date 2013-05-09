using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrator.BL.Extentions
{
    public static class StringExtention
    {

        public static string Truncate(this string value, int maxLength)
        {
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

    }
}
