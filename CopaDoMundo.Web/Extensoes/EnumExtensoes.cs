using CopaDoMundo.Web.Enum;
using System.ComponentModel;

namespace CopaDoMundo.Web.Extensoes
{
    public static class EnumExtensoes
    {
        public static string ToDescriptionString(this ePosicao val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
