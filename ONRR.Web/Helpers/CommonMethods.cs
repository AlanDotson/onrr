using System.Collections.Generic;
using System.Linq;

namespace QEP.ONRR.Web.Helpers
{
    public class CommonMethods
    {

        public static string ConvertCamelCaseString(string camelCase)
        {
            var chars = new List<char> { camelCase[0] };

            foreach (var c in camelCase.Skip(1))
            {
                if (char.IsUpper(c))
                {
                    chars.Add(' ');
                }
                chars.Add(c);
            }

            return new string(chars.ToArray());
        }
    }
}