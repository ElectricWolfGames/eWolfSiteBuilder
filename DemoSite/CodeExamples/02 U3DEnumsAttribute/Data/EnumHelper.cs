using System.ComponentModel;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace eWolf.CodeExamples.EnumnAttributes
{
    public class EnumHelper : MonoBehaviour
    {
        public static string GetEnumDescription(System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

        public static string GetEnumTitle(System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            TitleAttribute[] attributes =
                    fi.GetCustomAttributes(typeof(TitleAttribute), false) as TitleAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Title;
            }

            return value.ToString();
        }
    }
}