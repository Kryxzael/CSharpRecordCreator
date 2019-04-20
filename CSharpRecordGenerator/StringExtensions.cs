using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRecordGenerator
{
    public static class StringExtensions
    {
        public static string NormalizeCaps(this string input, bool firstCharCaps)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            if (firstCharCaps)
            {
                return char.ToUpper(input.First()) + input.Substring(1);
            }

            return char.ToLower(input.First()) + input.Substring(1);
        }
    }
}
