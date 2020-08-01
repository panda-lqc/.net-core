using MyAttribute.Attr;
using MyAttribute.CustomEnum;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyAttribute
{
    public static class EnumExt
    {
        public static string GetDescriptionThirdPart<T>(Enum value) where T:Enum 
        {
            Type type = value.GetType();
            var filed = type.GetField(value.ToString());
            if (filed.IsDefined(typeof(DescriptionAttribute),true))
            {
                DescriptionAttribute description = (DescriptionAttribute)filed.GetCustomAttribute(typeof(DescriptionAttribute), true);
                return description.Dscription;
            }
            else
            {
                return value.ToString();
            }
        }

        public static string GetDescription(this UserState value)
        {
            Type type = value.GetType();
            var filed = type.GetField(value.ToString());
            if (filed.IsDefined(typeof(DescriptionAttribute), true))
            {
                DescriptionAttribute description = (DescriptionAttribute)filed.GetCustomAttribute(typeof(DescriptionAttribute), true);
                return description.Dscription;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
