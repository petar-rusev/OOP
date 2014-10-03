using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringBuilderExtensions
{
    public static class Extensions
    {
        //Method for getting the substring from the stringbuilder object by the given start index and length of the string.
        public static string Substring(this StringBuilder b,int start, int length)
        {
            string res = "";
            if (start < 0 || length <= 0)
            {
                throw new ArgumentException("The start index and the length of the string can not be less than 0.");
            }
            else
            {
                for (int i = start; i < length; i++)
                {
                    res += b[i];
                }
                return res;
            }
        }

        public static void RemoveText(this StringBuilder b,string text)
        {
            Regex reg= new Regex(text,RegexOptions.IgnoreCase);
            string temp=reg.Replace(b.ToString(),"");
            b.Clear();
            b.Append(temp);
        }

        public static void AppendAll<T>(this StringBuilder b,IEnumerable<T>list)
        {
            T[] temp = list.ToArray();
            for (int i = 0; i<temp.Length; i++)
            {
                b.Append(temp[i].ToString());
            }

        }

    }
}
