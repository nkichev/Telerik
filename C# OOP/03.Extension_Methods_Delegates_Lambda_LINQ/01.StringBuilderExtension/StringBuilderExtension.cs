using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderExtension
{
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString().Substring(index, length));
        }
    }
}
