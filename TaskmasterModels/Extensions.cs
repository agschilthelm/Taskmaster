using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace TaskmasterModels
{
    public static class Extensions
    {
        public static string GetDisplayName<T>(this T Enum) where T : Enum
        {
            return Enum.GetEnumAttribute<T, DisplayAttribute>()?.Name;
        }

        public static TAttribute GetEnumAttribute<TEnum, TAttribute>(this TEnum Enum)
        where TEnum : Enum
        where TAttribute : Attribute
        {
            var MemberInfo = typeof(TEnum).GetMember(Enum.ToString());
            return MemberInfo[0].GetCustomAttribute<TAttribute>();
        }
    }
}
