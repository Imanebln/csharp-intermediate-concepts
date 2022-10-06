using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members__Constants_and_Extension_Methods
{
    public static class StringExtensions
    {
        public static string FirstLetterUpperCase(this string word)
        {
            char letter = Char.ToUpper(word[0]);
            string remaining = word.Substring(1);
            return letter + remaining;
        }
    }
}
