using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringMethod
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder subString = new StringBuilder();

            if (index < 0 || length < 0)
            {
                throw new ArgumentOutOfRangeException("StartIndex or length can not be less than zero");
            }
            else if (index + length > sb.Length - index + 1)
            {
                throw new ArgumentOutOfRangeException("StartIndex plus length indicates a position not within this instance.");
            }
            else
            {
                for (int i = index; i < index + length; i++)
                {
                    subString.Append(sb[i]);
                }

                return subString;
            }
        }
    }
}
