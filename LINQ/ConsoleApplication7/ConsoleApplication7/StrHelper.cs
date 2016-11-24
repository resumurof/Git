using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{

    #region StringHelper
    public static class StrHelper
    {
        public static string ChangeFirstLetterCase(this string name)
        {
            char[] nameconvertedtochar = name.ToCharArray();

            nameconvertedtochar[0] = char.IsUpper(nameconvertedtochar[0]) ? nameconvertedtochar[0] : char.ToUpper(nameconvertedtochar[0]);

            return new string(nameconvertedtochar);
        }
    }
    #endregion
}
