using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverser
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] stringArray = str.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);
        }
    }
}
