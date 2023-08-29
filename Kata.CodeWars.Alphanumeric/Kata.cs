using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.Alphanumeric
{
    public class Kata
    {
        public static bool Alphanumeric(string str)
        {
            return str.All(x => char.IsLetterOrDigit(x)) && !string.IsNullOrEmpty(str);
        }
    }
}
