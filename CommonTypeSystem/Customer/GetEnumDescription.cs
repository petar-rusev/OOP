using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
namespace Customer
{

    public enum CustomerType
    {
        [Description("One-Time")]
        OneTime,
        [Description("Regular")]
        Regular,
        [Description("Gold")]
        Gold,
        [Description("Diamond")]
        Diamond
    }
    public static class GetEnumDescription
    {
        public static string GetDescription(object enumValue, string defDesc)
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());

            if (fi!=null)
            {
                object[] attrs = fi.GetCustomAttributes(typeof(DescriptionAttribute), true);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return defDesc;
        }
    }

}
